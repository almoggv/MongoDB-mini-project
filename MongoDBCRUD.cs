using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;


namespace AudioCodes_First_Task___Almog_Geva
{
    //A mongoDB Atlas utility class
    //supports:
    //      * Entity Creation
    //      * Entity Update by Id
    //      * Loading of records
    //      
    //      * Deletion not supported
    class MongoDBCRUD
    {
        private IMongoDatabase m_DataBase;        
        private string m_LastUsedTable = "default";

        public string DbName { get; }
        public string LastUsedTable { get { return m_LastUsedTable; } }
        

        public MongoDBCRUD(string i_DbName)
        {           
            var client = new MongoClient("mongodb+srv://almogge:31663166Aa@filesdb.c1swt.mongodb.net/files?retryWrites=true&w=majority");                        
            m_DataBase = client.GetDatabase(i_DbName);                        

            this.DbName = i_DbName;
            this.m_LastUsedTable = "default";
        }

        public void InsertRecordAsync<T>(string i_TableName, T i_newRecord)
        {
            var tableCollection = m_DataBase.GetCollection<T>(i_TableName);
            tableCollection.InsertOneAsync(i_newRecord);
        }

        private void insertRecord<T>(string i_TableName, T i_newRecord)
            where T: IIdable
        {
            if(i_TableName == null)
            {
                throw new NullReferenceException();
            }
            m_LastUsedTable = i_TableName;                       

            var tableCollection = m_DataBase.GetCollection<T>(i_TableName);

            try
            {
                tableCollection.InsertOne(i_newRecord);
            }
            catch (Exception)
            {
                UpdateAndReplaceRecord(i_TableName, i_newRecord);
            }                       
        }

        public void PopulateDB<T>(string i_TableName ,List<T> i_DataList)
            where T: IIdable
        {            
            foreach (T item in i_DataList)
            {
                insertRecord(i_TableName, item);
            }
        }


        public List<T> LoadReccords<T>(string i_TableName)
        {
            var outCollection = m_DataBase.GetCollection<T>(i_TableName);
            var outBsonDoc = outCollection.Find(new MongoDB.Bson.BsonDocument());

            return outBsonDoc.ToList();
        }

        private T loadRecordById<T>(string i_TableName, string i_Id)
        {
            var filter = Builders<T>.Filter.Eq("_id", i_Id);
            var collection = m_DataBase.GetCollection<T>(i_TableName);

            var resultRecord = collection.Find(filter).FirstOrDefault();
            return resultRecord;
        }

        public void  UpdateAndReplaceRecord<T>(string i_TableName, T i_NewRecord)
            where T: IIdable
        {
            var collection = m_DataBase.GetCollection<T>(i_TableName);
            var filter = Builders<T>.Filter.Eq("_id", i_NewRecord.Id);
            collection.ReplaceOne(filter, i_NewRecord);                     
        }
    }
}
