using CQRS.Core.Events;

namespace Post.Common.Events;

public class PostRemovedEvent : BaseEvent
{
    public PostRemovedEvent() : base(nameof(PostRemovedEvent))
    {

    }

    // Additional properties can be added here if needed, such as PostId, UserId, etc.
}
