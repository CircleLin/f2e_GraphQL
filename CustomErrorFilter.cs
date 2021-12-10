using HotChocolate;

namespace f2e_GraphQL
{
    public class CustomErrorFilter : IErrorFilter
    {
        public IError OnError(IError error)
        {      
            if(error.Exception is not null)      
            {
                return error.WithMessage(error.Exception.Message);
            }
            else
            {
                return error.WithCode("no exception message");
            }
        }
    }
}