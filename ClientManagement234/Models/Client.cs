using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientManagement234.Models
{
    public class Client
    {
    
        
            public enum Status
            // Client/Status
            {
                WORKING,
                IN_PROGRESS,
                COMPLETED
            }
            public enum Rating
            // Client/Rating
            {
                GREAT,
                GOOD,
                POOR,
                BAD,
                NONE
            }

    }
}