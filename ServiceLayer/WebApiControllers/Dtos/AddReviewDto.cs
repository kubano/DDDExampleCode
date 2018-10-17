﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DataLayer.EfClasses.CrUDOnly;
using GenericServices;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.WebApiControllers.Dtos
{
    public class AddReviewDto : ILinkToEntity<Book>
    {
        [HiddenInput]
        public int BookId { get; set; }

        [ReadOnly(true)]
        public string Title { get; set; }

        [MaxLength(Review.NameLength)]
        public string VoterName { get; set; }

        public int NumStars { get; set; }
        public string Comment { get; set; }
    }
}