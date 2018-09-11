using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_napraw
{
    public enum Modes
    {
        MANAGER,
        ADMIN,
        WORKER,
        VIEW_ONLY,
        VIEW_ONLY_NO_REQUESTS,
        VIEW_MANAGERS,
        VIEW_WORKERS,
        EDIT
    }
}
