using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireBlazorCrudApp.Model.Models
{
    public class BaseResponseModel
    {
        // This class is used to standardize API responses across the application.
        // It contains properties to indicate the success status, a message, and any relevant data.
        // This helps in providing consistent feedback to the client for various operations.
        // Properties
        // Success: A boolean indicating whether the operation was successful.
        // ErrorMessage: A string to hold any error messages if the operation failed.   
        // Data: An object to hold any relevant data returned from the operation.

        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }


    }
}
