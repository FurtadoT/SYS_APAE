using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class Activity
    {
        int id;
        string title, description;
        DateTime dt_created;

        public Activity(int id, string title, string description, DateTime dt_created)
        {
            Id = id;
            Title = title;
            Description = description;
            Dt_created = dt_created;
        }

        public Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = new Dictionary<string, string>
            {
                { "id", Id.ToString() },
                { "title", Title.ToString() },
                { "description", Description.ToString() },
                { "dt_created", Dt_created.ToString("yyyy-MM-dd") },
            };

            return fieldsQuery;
        }

        public Dictionary<string, string> GetFieldsToDisplay()
        {
            Dictionary<string, string> displayFields = new Dictionary<string, string>
            {
                { "id", Id.ToString() },
                { "title", Title.ToString() },
                { "description", Description.ToString() },
            };

            return displayFields;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime Dt_created
        {
            get
            {
                return dt_created;
            }

            set
            {
                dt_created = value;
            }
        }
    }
}
