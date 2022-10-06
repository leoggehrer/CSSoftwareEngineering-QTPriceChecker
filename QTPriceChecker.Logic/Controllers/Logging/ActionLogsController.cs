//@CodeCopy
//MdStart
#if ACCOUNT_ON && LOGGING_ON
using QTPriceChecker.Logic.Entities.Logging;

namespace QTPriceChecker.Logic.Controllers.Logging
{
    internal sealed partial class ActionLogsController : GenericController<ActionLog>
    {
        public ActionLogsController()
        {
        }

        public ActionLogsController(ControllerObject other) : base(other)
        {
        }
    }
}
#endif
//MdEnd
