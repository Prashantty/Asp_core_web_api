﻿using System.Reflection.PortableExecutable;

namespace TaskApi.Models
{
    public class SubTask
    {// Add properties
        // Id, SubTaskName, Created By, Created On, Description,
        // TaskId

        public int Id { get; set; }
        public string SubTaskName { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string Description { get; set;}

        public Tsk Tsk { get; set; }  
        public int TskId { get; set; }


    }
}
