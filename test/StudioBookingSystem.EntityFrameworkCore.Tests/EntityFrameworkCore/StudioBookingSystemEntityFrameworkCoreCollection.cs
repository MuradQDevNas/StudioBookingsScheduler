﻿using Xunit;

namespace StudioBookingSystem.EntityFrameworkCore;

[CollectionDefinition(StudioBookingSystemTestConsts.CollectionDefinitionName)]
public class StudioBookingSystemEntityFrameworkCoreCollection : ICollectionFixture<StudioBookingSystemEntityFrameworkCoreFixture>
{

}
