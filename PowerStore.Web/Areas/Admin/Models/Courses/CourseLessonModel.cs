﻿using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Courses
{
    public partial class CourseLessonModel : BaseEntityModel
    {
        public CourseLessonModel()
        {
            AvailableSubjects = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.ShortDescription")]
        public string ShortDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Description")]
        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public string CourseId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.SubjectId")]
        public string SubjectId { get; set; }
        public IList<SelectListItem> AvailableSubjects { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.VideoFile")]
        [UIHint("Download")]
        public string VideoFile { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.AttachmentId")]
        [UIHint("Download")]
        public string AttachmentId { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.PictureId")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Published")]
        public bool Published { get; set; }


    }
}
