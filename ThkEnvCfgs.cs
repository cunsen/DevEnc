using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using System.Reflection;

namespace ThkDevEnc
{
    public class ThkEnvCfgs
    {
        protected string strCfgFile;
        protected string strCfgPath;
        protected ThkEnvConfigs envconfigs;

        public ThkEnvCfgs()
        {
            strCfgFile = "ThkDevEnv.config";

            string path = System.Environment.CurrentDirectory;
            Assembly myAssembly = Assembly.GetEntryAssembly();
            if (myAssembly == null)
                myAssembly = Assembly.GetExecutingAssembly();
            if (myAssembly != null)
            {
                path = myAssembly.Location;
                DirectoryInfo dr = new DirectoryInfo(path);
                path = dr.Parent.FullName;  //当前目录的上一级目录
            }

            strCfgPath = path + "\\";
            envconfigs = new ThkEnvConfigs();
        }

        public string StrCfgFile
        {
            get { return strCfgFile; }
            set { strCfgFile = value; }
        }
        public string StrCfgPath
        {
            get { return strCfgPath; }
            set { strCfgPath = value; }
        }
        public bool LoadConfig()
        {
            XmlSerializer s = new XmlSerializer(typeof(ThkEnvConfigs));
            string fname = strCfgPath + strCfgFile;
            FileInfo fi = new FileInfo(fname);
            if (!fi.Exists)
            {
                TextWriter w = new StreamWriter(fname);
                s.Serialize(w, envconfigs);
                w.Close();
            }
            else
            {
                TextReader r = new StreamReader(fname);
                envconfigs = (ThkEnvConfigs)s.Deserialize(r);
                r.Close();
            }
            return true;
        }
        public bool SaveConfig()
        {
            XmlSerializer s = new XmlSerializer(typeof(ThkEnvConfigs));
            string fname = strCfgPath + strCfgFile;
            FileInfo fi = new FileInfo(fname);
            if (fi.Exists)
            {
                fi.Delete();
            }
            TextWriter w = new StreamWriter(fname);
            s.Serialize(w, envconfigs);
            w.Close();
            return true;
        }
        public bool LoadEnvs(string fname)
        {
            strCfgFile = fname;
            return LoadConfig();
        }
        public void AddEnvConfig(ThkEnvConfig ec)
        {
            envconfigs.AddEnvConfig(ec);
        }
        public ThkEnvConfig[] GetAllConfig()
        {
            return envconfigs.EnvConfigItems;
        }
        public ThkEnvConfig GetEnvConfig(int idx)
        {
            ThkEnvConfig[] arrcfg = envconfigs.EnvConfigItems;
            if (idx < 0 || idx >= arrcfg.Length)
                return null;
            return arrcfg[idx];
        }
        public ThkEnvConfig GetCurEnvConfig()
        {
            ThkEnvConfig[] arrcfg = envconfigs.EnvConfigItems;
            string strcurcfg = envconfigs.StrCurConfig;
            if (strcurcfg == null || strcurcfg.Length == 0)
            {
                if(arrcfg.Length !=0)
                    return arrcfg[0];
            }
            foreach (ThkEnvConfig i in arrcfg)
            {
                if (i.ConfigName == strcurcfg)
                    return i;
            }
            return null;
        }
        public void SetCurEnvConfig(int nidx)
        {
            ThkEnvConfig enc = GetEnvConfig(nidx);
            if (enc == null)
                return;
            envconfigs.StrCurConfig = enc.ConfigName;
        }

        public ThkVCDirSet GetVCConfig()
        {
            return envconfigs.VcConfig;
        }

        public ThkProeDirCfgs GetProeDirs()
        {
            return envconfigs.ProeCfgs;
        }
    }

 
    [XmlRoot("ThkEnvConfigs")]
    public class ThkEnvConfigs
    {
        ArrayList arrCfgItem = new ArrayList();
        ThkVCDirSet vcSet = new ThkVCDirSet();
        ThkProeDirCfgs proeCfgs = new ThkProeDirCfgs();

        [XmlElement("ProeConfigs")]
        public ThkProeDirCfgs ProeCfgs
        {
            get { return proeCfgs; }
            set { proeCfgs = value; }
        }

        [XmlElement("VCCONFIGS")]
        public ThkVCDirSet VcConfig
        {
            get { return vcSet; }
            set { vcSet = value; }
        }

        string strCurConfig;

        [XmlElement("CurEnvConfig")]
        public string StrCurConfig
        {
            get { return strCurConfig; }
            set { strCurConfig = value; }
        }

        public ThkEnvConfigs()
        {
        }

        [XmlElement("ThkEnvConfig")]
        public ThkEnvConfig[] EnvConfigItems
        {
            get
            {
                ThkEnvConfig[] items = new ThkEnvConfig[arrCfgItem.Count];
                arrCfgItem.CopyTo(items);
                return items;

            }
            set
            {
                if (value == null) return;
                ThkEnvConfig[] items = (ThkEnvConfig[])value;
                arrCfgItem.Clear();
                foreach (ThkEnvConfig i in items)
                    arrCfgItem.Add(i);

            }
        }
        public void AddEnvConfig(ThkEnvConfig ec)
        {
            arrCfgItem.Add(ec);
        }
        public bool AddProeDir(String strdir)
        {
            return proeCfgs.AddProeDirs(strdir);
        }

    }

   // [XmlRoot("ProeConfigs")]
    public class ThkProeDirCfgs
    {
        ArrayList arrProeCfg = new ArrayList();
        string strLastToolkitDir = "";

        public ThkProeDirCfgs()
        {
        }
        [XmlElement("LastToolkitDir")]
        public string LastToolkitDir
        {
            get { return strLastToolkitDir; }
            set { strLastToolkitDir = value; }
        }
    
        [XmlElement("ProeDir")]
        public String[] EnvProeDirItems
        {
            get
            {
                String[] items = new String[arrProeCfg.Count];
                arrProeCfg.CopyTo(items);
                return items;

            }
            set
            {
                if (value == null) return;
                String[] items = (String[])value;
                arrProeCfg.Clear();
                foreach (String i in items)
                    arrProeCfg.Add(i);

            }
        }
        public bool AddProeDirs(String ec)
        {
            foreach (String i in arrProeCfg)
            {
                if (String.Compare(i, ec, true) == 0)
                    return false;
            }
            arrProeCfg.Add(ec);
            return true;
        }
    }

    public class ThkEnvConfig
    {
        string strConfigName;
        ArrayList arrCfgItem = new ArrayList();

        [XmlElement("ConfigName")]
        public string ConfigName
        {
            get { return strConfigName; }
            set { strConfigName = value; }
        }
        [XmlElement("ThkEnvItem")]
        public ThkEnvCfgItem[] EnvConfigItems
        {
            get
            {
                ThkEnvCfgItem[] items = new ThkEnvCfgItem[arrCfgItem.Count];
                arrCfgItem.CopyTo(items);
                return items;

            }
            set
            {
                if (value == null) return;
                ThkEnvCfgItem[] items = (ThkEnvCfgItem[])value;
                arrCfgItem.Clear();
                foreach (ThkEnvCfgItem i in items)
                    arrCfgItem.Add(i);

            }
        }
        public void AddEnvItem(string strenv, string strval,string strplatform)
        {
            ThkEnvCfgItem eci = new ThkEnvCfgItem();
            eci.EnvCfgItem = strenv;
            eci.EnvCfgValue = strval;
            eci.EnvCfgFlatform = strplatform;
            arrCfgItem.Add(eci);
        }
        public bool UpdEnvItem(int nIdx, string strenv, string strval, string strplatform)
        {
            if (nIdx < 0 || nIdx >= arrCfgItem.Count)
                return false;//AddEnvItem(strenv, strval, strplatform);
            else
            {
                ThkEnvCfgItem eci = (ThkEnvCfgItem)arrCfgItem[nIdx];
                eci.EnvCfgFlatform = strplatform;
                eci.EnvCfgItem = strenv;
                eci.EnvCfgValue = strval;
                return true;
            }
        }
        public bool DelEnvItem(int nIdx)
        {
            if (nIdx < 0 || nIdx >= arrCfgItem.Count)
                return false;
            arrCfgItem.RemoveAt(nIdx);
            return true;
        }
    }

    public class ThkEnvCfgItem
    {
        string strCfgItem;

        [XmlElement("EnvName")]
        public string EnvCfgItem
        {
            get { return strCfgItem; }
            set { strCfgItem = value; }
        }
        string strCfgValue;

        [XmlElement("EnvValue")]
        public string EnvCfgValue
        {
            get { return strCfgValue; }
            set { strCfgValue = value; }
        }
        string strCfgFlatform;
        [XmlElement("EnvFlatform")]
        public string EnvCfgFlatform
        {
            get { return strCfgFlatform; }
            set { strCfgFlatform = value; }
        }
    }
}
