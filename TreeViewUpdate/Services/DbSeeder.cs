using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewUpdate.Entities;

namespace TreeViewUpdate.Services
{
    public static class DbSeeder
    {
        public static void SeedAll(EFContext context) 
        {
            SeedCategories(context);
        }
        private static void SeedCategories(EFContext context) 
        {
            if (context.Categories.Count() == 0) 
            {
                string UrlSlug = "cars";
                AddParent(context, "Cars", UrlSlug);
                AddChildren(context, "BMW", UrlSlug, "bmw-cars");
                AddChildren(context, "Mercedes", UrlSlug, "mercedes-cars");
                AddChildren(context, "Opel", UrlSlug, "opel-cars");

                AddChildren(context, "Opel Astra", "opel-cars", "opel-astra");
                AddChildren(context, "Opel Vectra", "opel-cars", "opel-vectra");

                UrlSlug = "trucks";
                AddParent(context, "Trucks", UrlSlug);
                AddChildren(context, "Ford", UrlSlug, "ford-trucks");
                AddChildren(context, "MAN", UrlSlug, "man-trucks");
            }
        }
        private static void AddParent(EFContext context, string name, string UrlSlug) 
        {
            context.Categories.Add(new Entities.TreeViewUpdate { 
                Name = name,
                UrlSlug = UrlSlug,
                ParentId = null
            });
            context.SaveChanges();
        }
        private static void AddChildren(EFContext context, string name, string parentUrlSlug, string urlSlug) 
        {
            Entities.TreeViewUpdate el = context.Categories.FirstOrDefault(x => x.UrlSlug == parentUrlSlug);
            if (el != null) 
            {
                context.Categories.Add(new Entities.TreeViewUpdate { 
                    Name = name,
                    UrlSlug = urlSlug,
                    ParentId = el.Id
                });
                context.SaveChanges();
            }
        }
    }
}
