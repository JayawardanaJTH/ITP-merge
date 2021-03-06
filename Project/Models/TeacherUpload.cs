﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class TeacherUpload
    {
       
        public int teacher_id { get; set; }

        [Required(ErrorMessage = "Please fill this section")]
        public int subject_id { get; set; }

        [Required(ErrorMessage = "Please fill this section")]
        public int grade_id { get; set; }

        public string teacherName { get; set; }

        public string subject { get; set; }

        public string grade { get; set; }

        [DisplayName("File ID")]
        public int file_id { get; set; }

        [DisplayName("File Name")]
        public string file_name { get; set; }

        [DisplayName("Upload Date")]
        public System.DateTime upload_date { get; set; }

        [DisplayName("File Path")]
        public string file_path { get; set; }

    }
}