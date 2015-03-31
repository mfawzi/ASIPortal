﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DominosCMS.Models;

namespace DominosCMS.Web.Areas.Admin.Models
{
    public class EditMenuModel
    {
        public MenuItem Page { get; set; }

        public int[] SelectedGroups { get; set; }
        public int[] SelectedUsers { get; set; }

        public IList<Group> Groups { get; set; }
        public IList<Account> Users { get; set; }

    }
}