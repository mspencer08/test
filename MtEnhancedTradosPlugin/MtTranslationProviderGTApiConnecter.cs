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
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Globalization;
using Sdl.LanguagePlatform.Core;


namespace MtEnhancedTradosPlugin
{
    public class MtTranslationProviderGTApiConnecter
    {


        private string keyIn;
        //holds supported languages so we don't have to keep pinging google once the lang has been checked
        //the structure is <targetLang, List<sourceLangs>>
        private static Dictionary<string, List<string>> dictSupportedLangs;

        public string ApiKey //for when this is already instantiated but key is changed in dialog
        {
            get { return keyIn; }
            set { keyIn = value; }
        }

        public MtTranslationProviderGTApiConnecter(String key)
        {

            keyIn = key;
        }

        private void UpdateSupportedLangs(string target)
        {
            List<string> list = GetSourceLangsList(target);
            if (list == null) //returns null if error
            {
                string message = PluginResources.LangPairAuthErrorMsg1 + Environment.NewLine + PluginResources.LangPairAuthErrorMsg2;// +Environment.NewLine + PluginResources.LangPairAuthErrorMsg3;
                throw new Exception(message); //b/c list will come back null if key is bad
            }

            dictSupportedLangs.Add(target, list);
        }

        public bool isSupportedLangPair(CultureInfo sourceCulture, CultureInfo targetCulture)
        {
            string sourceLang = GetLanguageCode(sourceCulture);
            string targetLang = GetLanguageCode(targetCulture);
            if (dictSupportedLangs == null)
                dictSupportedLangs = new Dictionary<string, List<string>>();
            if (!dictSupportedLangs.ContainsKey(targetLang))
                UpdateSupportedLangs(targetLang);
            foreach (string source in dictSupportedLangs[targetLang])
            {
                if (source == sourceLang)
                {
                    return true;
                }
            }
            //otherwise return false
            return false;
        }

        /// <summary>
        /// Used to translate plain text only.
        /// </summary>
        /// <param name="langPair"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public String Translate(LanguagePair langPair, String text) //this is called for just plain text
        {
            String format = "html";
            text = HttpUtility.HtmlEncode(text); //we want to HtmlEncode a plain text segment
            string result = DoTranslate(langPair, text, format);
            return result;
        }

        /// <summary>
        /// Used to translate as html to allow for tag markup
        /// </summary>
        /// <param name="langPair"></param>
        /// <param name="text"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public String Translate(LanguagePair langPair, String text, String format) //this is called for segments with tags
        {
            //here we do not HtmlEncode b/c the tagplacer will do that later..selectively
            string result = DoTranslate(langPair, text, format);
            return result;
        }


        private String DoTranslate(LanguagePair langPair, String text, String format)
        {
            if (ApiKey == null || ApiKey == string.Empty)
            {
                throw new Exception(PluginResources.ApiConnectionGoogleNoKeyErrorMessage);
            }

            string sourceLang = GetLanguageCode(langPair.SourceCulture); //shorten the input localized langs into 2-digit where applicable
            string targetLang = GetLanguageCode(langPair.TargetCulture);

            #region "Encoding"
            text = EncodeSpecialChars(text); //all strings should get this final check for characters that seem to break GT api
            #endregion

            //create the url for the translate request
            string url = String.Format("https://www.googleapis.com/language/translate/v2?key={0}&q={1}&source={2}&target={3}&prettyprint=true", keyIn, text, sourceLang, targetLang);

            if (format != "") //add format if provided
            {
                url += "&format=" + format;
            }

            string result = ""; //this will take the result from the webclient

            //delete the follwoing line for production...only to be able to trace http calls using Fiddler
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                try
                {
                    result = webClient.DownloadString(url);  //gets us the json data indicating supported source languages for this target
                }
                catch (WebException e) //will come back 400 bad request if there is a problem
                {
                    string eReason = GetExceptionReason(e);
                    //get our localized error message from the resources file
                    string message = PluginResources.ApiConnectorGoogleAuthErrorMsg1 + Environment.NewLine + PluginResources.ApiConnectorGoogleAuthErrorMsg2;
                    throw new Exception(eReason);
                }
            }

            //need to parse results and find key "translatedText" - there should be only one
            String returnedResult = parseReturnedResults(result, "translatedText")[0];

            string decodedResult = HttpUtility.HtmlDecode(returnedResult); //google seems to send back html codes at times


            //for some reason, GT is sometimes adding zero-width spaces, aka "bom", aka char(8203)
            //so we need to remove it
            decodedResult = GtRemoveBoms(decodedResult);
            return decodedResult;
        }


        private string GtRemoveBoms(string input)
        {
            //this is to deal with google putting in zero-width spaces for some reason, i.e. char(8203)
            //convert returned text to char array
            char[] chars = input.ToCharArray();
            //remove all char8203 using linq                 
            chars = chars.Where(val => val != (char)8203).ToArray();
            //convert back to a string
            return new string(chars);
        }

        private string GetLanguageCode(CultureInfo ci)
        {
            string strReturn = "";

            if (ci.Name == "zh-TW" || ci.Name == "zh-CN") { return ci.Name; } //just get the name for zh-TW which Google can process..google can also process simplified when specifying target as zh-CN but it breaks when you specify that as source??
            if (ci.Name.Equals("nb-NO") || ci.Name.Equals("nn-NO")) return "no";

            strReturn = ci.TwoLetterISOLanguageName; //if not chinese trad or norweigian get 2 letter code

            //convert tagalog and hebrew for Google
            if (strReturn == "fil") { strReturn = "tl"; }
            if (strReturn == "he") { strReturn = "iw"; }

            return strReturn;
        }


        private string EncodeSpecialChars(string strInput)
        {
            //google can't handle some url encoded characters
            //but if we UrlEncodeUnicode all of them
            //it screws up non-latin alphabet languages
            //...workaround:
            strInput = strInput.Replace("#", "%23");
            strInput = strInput.Replace("&", "%26");
            strInput = strInput.Replace(";", "%3b");

            return strInput;
        }

        public List<string> GetSourceLangsList(string targetLang)
        {
            string url = String.Format("https://www.googleapis.com/language/translate/v2/languages?key={0}&target={1}", keyIn, targetLang);
            string result = ""; //this will take the result from the webclient
            List<string> list = new List<string>();

            #region "webclient"
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    result = webClient.DownloadString(url);  //gets us the json data indicating supported source languages for this target
                }
                catch (WebException e) //will come back 400 invalid value if target lang not supported
                {
                    string eReason = GetExceptionReason(e);
                    if (eReason == "Bad Request")
                    {
                        return null; //send this up to provider and it knows what to do
                    }
                    //otherwise, if it is b/c of a non-supported targetLang, eReason will be "Invalid Value"
                    list.Add("unsupported");
                    return list;
                }
            }
            #endregion


            foreach (string lang in parseReturnedResults(result, "language")) //the second arg is the key we'll be looking for
            {
                //have to parse for zh-CN, which for some reason google returns as only 'zh' on a supported language check...although it seems to accept it on translation calls...i think? 
                string filtered_lang = lang;
                if (filtered_lang.Equals("zh")) filtered_lang += "-CN";

                list.Add(filtered_lang);//put the source lang in the list
            }

            return list;
        }


        private string parseReturnedError(string input)
        {

            //this is different from successful response parses
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Dictionary<string, Dictionary<string, object>> dict = new Dictionary<string, Dictionary<string, object>>();
            Dictionary<string, object> dict2;
            string message = "";

            dict = ser.Deserialize<Dictionary<string, Dictionary<string, object>>>(input);
            foreach (String strKey in dict.Keys) //this structure gets it out
            {
                object o = dict[strKey];
                dict2 = (Dictionary<string, object>)o;
                object o2 = dict2["message"];
                message = dict2["message"].ToString();
            }

            return message;
        }


        private List<string> parseReturnedResults(string input, string findKey)
        {

            #region "variables"
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Dictionary<string, Dictionary<string, object>> dict = new Dictionary<string, Dictionary<string, object>>();
            Dictionary<string, object> dict2;
            Dictionary<string, object> dict3;
            System.Collections.ArrayList myAl;
            List<string> myList = new List<string>();
            #endregion

            #region "loopthrough"
            dict = ser.Deserialize<Dictionary<string, Dictionary<string, object>>>(input);
            //loop through output 
            foreach (String strKey in dict.Keys) //this structure seems to be the only way to get it out
            {
                object o = dict[strKey];
                dict2 = (Dictionary<string, object>)o;
                foreach (String strKey2 in dict2.Keys)
                {
                    object o2 = dict2[strKey2];
                    myAl = (System.Collections.ArrayList)o2;
                    for (int i = 0; i < myAl.Count; i++)
                    {
                        object o3 = myAl[i];
                        dict3 = (Dictionary<string, object>)o3;
                        myList.Add(dict3[findKey].ToString()); //we change the key depending on if we are translating or checking languages
                    }
                }
            }
            #endregion

            return myList;


        }

        /// <summary>
        /// 
        /// need to handle this differently from translate b/c the json is formed differently
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ParseLanguageDetect(string input)
        {
            #region "variables"
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Dictionary<string, Dictionary<string, object>> dict = new Dictionary<string, Dictionary<string, object>>();
            Dictionary<string, object> dict2;
            //Dictionary<string, object> dict3;
            System.Collections.ArrayList myAl;
            System.Collections.ArrayList myAl2;
            //System.Collections.ArrayList myAl3;
            List<string> myList = new List<string>();
            #endregion

            #region "loopthrough"
            dict = ser.Deserialize<Dictionary<string, Dictionary<string, object>>>(input);
            //loop through output 
            foreach (String strKey in dict.Keys) //this structure seems to be the only way to get it out
            {
                object o = dict[strKey];
                dict2 = (Dictionary<string, object>)o;
                foreach (String strKey2 in dict2.Keys)
                {
                    object o2 = dict2[strKey2];
                    myAl = (System.Collections.ArrayList)o2;
                    myAl2 = (System.Collections.ArrayList)myAl[0];
                    object o3 = myAl2[0];
                    Dictionary<string, object> pairs = (Dictionary<string, object>)o3;
                    return pairs["language"].ToString();


                }


            }
            #endregion

            return null;

        }

        private string GetExceptionReason(WebException exception)
        {
            System.IO.Stream myStream = exception.Response.GetResponseStream();
            bool xx = myStream.CanRead;
            System.IO.StreamReader x = new System.IO.StreamReader(myStream);
            string contents = x.ReadToEnd();
            string reason = parseReturnedError(contents);

            return reason;

        }
    }
}
