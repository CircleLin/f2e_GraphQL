using HotChocolate;

namespace f2e_GraphQL
{
    public class CustomErrorFilter : IErrorFilter
    {
        public IError OnError(IError error)
        {
            return error.WithMessage(error.Exception?.Message);
        }
    }
}