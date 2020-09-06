﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace ASP3MVC.Models
{
    public class DictObjectContext
    {
        string JSONPath = "D://data.json";

        public List<DictObject> GetAll()
        {
            List<DictObject> dictObjects = JsonConvert.DeserializeObject<List<DictObject>>(File.ReadAllText(JSONPath, Encoding.UTF8));
            return dictObjects;
        }

        public string GetAllJSON()
        {
            return File.ReadAllText(JSONPath, Encoding.UTF8);
        }

        public bool Add(DictObject dictObject)
        {
            try
            {
                List<DictObject> dictObjects = GetAll();
                dictObjects.Add(dictObject);
                File.WriteAllText(JSONPath, JsonConvert.SerializeObject(dictObjects));
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public DictObject Find(int id)
        //{
        //    List<DictObject> dictObjects = GetAll();
        //    return dictObjects.Find(x => x.Id == id);
        //}
    }
}