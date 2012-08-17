﻿namespace Loki.Net
{
    public enum InteroperabilityOperationCode : short
    {
        RegistrationRequest,
        RegistrationResponse,
        CharacterEntriesRequest,
        CharacterEntriesResponse,
        CharacterNameCheckRequest,
        CharacterNameCheckResponse,
        CharacterDeletionRequest,
        CharacterCreationRequest,
        CharacterCreationResponse,
        ChannelIDUpdate,
        LoggedInCheck,
        LoggedInUpdate,
        ChannelPortRequest,
        ChannelPortResponse,
        LoadInformationRequest,
        LoadInformationResponse,
        IsMasterCheck,
        GetCashRequest,
        GetCashResponse,
        SetCashRequest
    }
}