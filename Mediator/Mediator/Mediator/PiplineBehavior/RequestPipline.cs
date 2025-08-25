using FluentValidation;
using MediatR;

namespace Mediator.PiplineBehavior
{
    public class RequestPipline<TRequest, TResponse> : IPipelineBehavior<TRequest , TResponse>
        where TRequest : IRequest<TResponse>
    {
         private readonly IEnumerable<IValidator<TRequest>> _validators;

        public RequestPipline(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators= validators;
        }
        public Task<TResponse> Handle(TRequest request , RequestHandlerDelegate<TResponse> next , CancellationToken cancellationToken)
        {

            var context = new ValidationContext<TRequest>(request);
            var failiers = _validators.Select(o=>o.Validate(context)).SelectMany(ob=>ob.Errors).Where(item=>item != null).ToList();
            if(failiers.Any() ) 
            {
                
                throw new ValidationException(failiers);
            }
            return next();
        }
    }


}
