﻿/* Copyright 2015 Patrick Porter

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace MtEnhancedTradosPlugin
{
    public class SegmentEditor
    {
        string filename;
        EditCollection edcoll;
        DateTime lastversion;

        public SegmentEditor(string editCollectionFilename)
        {
            filename = editCollectionFilename;
            lastversion = File.GetLastWriteTime(filename);
            LoadCollection();
        }

        public void LoadCollection()
        {
            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(EditCollection));
                    edcoll = (EditCollection)serializer.Deserialize(reader);
                }
            }
            catch (InvalidOperationException) //invalid operation is what happens when the xml can't be parsed into the objects correctly
            {
                //FUTURE: do we want a message box here or just throw the exception up to studio????
                string caption = PluginResources.EditSettingsErrorCaption;
                string message = string.Format(PluginResources.EditSettingsXmlErrorMessage, Path.GetFileName(filename));
                MessageBox.Show(new MtWindowWrapper(getHandle()), message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message);
            }
            catch (Exception exp) //catch-all for any other kind of error...passes up a general message with the error description
            {
                //FUTURE: do we want a message box here or just throw the exception up to studio????
                string caption = PluginResources.EditSettingsErrorCaption;
                string message = PluginResources.EditSettingsGenericErrorMessage + " " + exp.Message;
                MessageBox.Show(new MtWindowWrapper(getHandle()), message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message); //throwing exception aborts the segment lookup

            }
        }

        public string EditText(string text)
        {
            string result = text;
            //check last time edit file was written to and if its changed reload the collection.
            DateTime currentversion = File.GetLastWriteTime(filename);
            if (currentversion > lastversion)
            {
                lastversion = currentversion;
                LoadCollection();
            }

            if (edcoll.Items.Count == 0)
                return text;

            
            for (int i = 0; i< edcoll.Items.Count; i++)
            {
                if (edcoll.Items[i].Enabled) //need to skip when disabled
                {
                    string find = edcoll.Items[i].FindText;
                    string replace = edcoll.Items[i].ReplaceText;

                    if (edcoll.Items[i].Type == EditItem.EditItemType.PlainText)
                    {
                        result = result.Replace(find, replace);
                    }
                    else if (edcoll.Items[i].Type == EditItem.EditItemType.RegularExpression)
                    {
                        Regex reg = new Regex(find);
                        result = reg.Replace(result, replace);
                    }
                }
            }

            return result;
        }

        private IntPtr getHandle()
        { //this allows us to get the handle of the main Studio window so we can instantiate our WindowWrapper class 
            //used for making our messagebox modal
            //Get FriendlyName from Application Domain
            string strFriendlyName = AppDomain.CurrentDomain.FriendlyName;

            //Get process collection by the application name without extension (.exe)
            Process[] pro = Process.GetProcessesByName(strFriendlyName.Substring(0, strFriendlyName.LastIndexOf('.')));
            return pro[0].MainWindowHandle;

        }
    }

}
