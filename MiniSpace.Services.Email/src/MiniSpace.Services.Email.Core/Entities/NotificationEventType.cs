namespace MiniSpace.Services.Email.Core.Entities
{
    public enum NotificationEventType
    {
        NewFriendRequest,
        FriendRequestAccepted,
        NewEvent,
        EventDeleted,
        EventNewSignUp,
        EventNewSignUpFriend,
        StudentCancelledSignedUpToEvent,
        StudentShowedInterestInEvent,
        StudentCancelledInterestInEvent,
        EventParticipantAdded,
        EventParticipantRemoved,
        PostCreated,
        PostUpdated,
        MentionedInPost,
        EventReminder,
        PasswordResetRequest,
        UserSignUp,
        Other
    }
}