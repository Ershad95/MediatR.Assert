// See https://aka.ms/new-console-template for more information

using MediatR;

namespace ApplicationLayer;

public class ErshadCommand : IRequest<Unit>
{
    public int Age { get; set; }
    public string Mobile { get; set; }
    public string Name { get; set; }
}

public class ErshadCommandHandler : IRequestHandler<ErshadCommand, Unit>
{
    public Task<Unit> Handle(ErshadCommand request, CancellationToken cancellationToken)
    {
        return Unit.Task;
    }
}

public class ErshadNotification : INotification
{
    public int Age { get; set; }
    public string Mobile { get; set; }
    public string Name { get; set; }
}

public class ErshadNotificationHandler : INotificationHandler<ErshadNotification>
{
    public Task Handle(ErshadNotification notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

public class ErshadQuery : IRequest<Unit>
{
    public int Age { get; set; }
    public string Mobile { get; set; }
    public string Name { get; set; }
}

public class ErshadQueryHandler : IRequestHandler<ErshadQuery, Unit>
{
    public Task<Unit> Handle(ErshadQuery request, CancellationToken cancellationToken)
    {
        return Unit.Task;
    }
}