using CQRS.Core.Events;

namespace Post.Common.Events;

internal class PostLikedEvent : BaseEvent
{
    public PostLikedEvent() : base(nameof(PostLikedEvent))
    {
    }
}
