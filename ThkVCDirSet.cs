using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Serialization;

namespace ThkDevEnc
{
    
    public class ThkVCDirSet
    {
         ArrayList arrVCItem = new ArrayList();

        ThkVCDirItem vcDefault = new ThkVCDirItem();
        string curVCItem = "当前IDE环境";

        [XmlElement("VC_CURRENT")]
        public string CurVCItem
        {
            get { return curVCItem; }
            set { curVCItem = value; }
        }

        public ThkVCDirSet()
        {
            curVCItem = "当前IDE环境";
            vcDefault.StrVCVer = curVCItem;
            vcDefault.StrVCDir = Environment.GetEnvironmentVariable("VSINSTALLDIR", EnvironmentVariableTarget.Process);
            if(vcDefault.StrVCDir == null || vcDefault.StrVCDir.Length ==0)
                vcDefault.StrVCDir = Environment.GetEnvironmentVariable("VSINSTALLDIR");
            if (vcDefault.StrVCDir == null || vcDefault.StrVCDir.Length == 0)
            {
                vcDefault.StrVCDir = "";
            }
            vcDefault.StrSDKDir = "";
      }

        public ThkVCDirItem VcDefault
        {
            get {
                return vcDefault; 
            }
            set { vcDefault = value; }
        }

       
        [XmlElement("VC_ITEM")]
        public ThkVCDirItem[] EnvConfigItems
        {
            get
            {
                ThkVCDirItem[] items = new ThkVCDirItem[arrVCItem.Count];
                arrVCItem.CopyTo(items);
                return items;

            }
            set
            {
                if (value == null) return;
                ThkVCDirItem[] items = (ThkVCDirItem[])value;
                arrVCItem.Clear();
                foreach (ThkVCDirItem i in items)
                    arrVCItem.Add(i);

            }
        }
        public void AddVcConfig(string strVer, string strDir, string strSDKdir)
        {
            ThkVCDirItem vci = new ThkVCDirItem();
            vci.StrVCVer = strVer;
            vci.StrVCDir = strDir;
            vci.StrSDKDir = strSDKdir;
            arrVCItem.Add(vci);
        }
        public ThkVCDirItem GetCurVCItem()
        {
            if (curVCItem == vcDefault.StrVCVer)
                return vcDefault;
            foreach (ThkVCDirItem i in arrVCItem)
            {
                if (curVCItem == i.StrVCVer)
                    return i;
            }
            return null;
        }
        public ThkVCDirItem GetVcItem(string strVer)
        {
            foreach (ThkVCDirItem i in arrVCItem)
            {
                if (strVer == i.StrVCVer)
                    return i;
            }
            return null;
        }
    }

    public class ThkVCDirItem
    {
        string strVCVer;//VC2008/VC2005==
        [XmlElement("VCVER")]
        public string StrVCVer
        {
            get { return strVCVer; }
            set { strVCVer = value; }
        }
        string strVCDir;
        [XmlElement("VCDIR")]
        public string StrVCDir
        {
            get { return strVCDir; }
            set { strVCDir = value; }
        }
        string strSDKDir;

        [XmlElement("SDKDIR")]
        public string StrSDKDir
        {
            get { return strSDKDir; }
            set { strSDKDir = value; }
        }
    }

}
