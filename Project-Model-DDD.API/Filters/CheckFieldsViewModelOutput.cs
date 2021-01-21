using System.Collections.Generic;

namespace Project_Model_DDD.API.Filters
{
    public class CheckFieldsViewModelOutput
    {
        public IEnumerable<string> Errors { get; private set; }

        public CheckFieldsViewModelOutput(IEnumerable<string> errors)
        {
            Errors = errors;
        }

    }
}
