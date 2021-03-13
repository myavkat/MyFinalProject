using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added.";
        public static string ProductNameInvalid = "Product's name is invalid.";
        public static string ProductsListed = "Products listed.";
        public static string MaintenanceTime = "System is under maintenance.";
        public static string ProductLimitOfCategoryReached = "This category reached its limit of products.";
        public static string ProductNameAlreadyExists = "Product name already exists in database.";
        public static string CategoryLimitExceeded = "Category limit reached.";
    }
}
