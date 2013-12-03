﻿using Amido.NAuto.Builders;

namespace Amido.NAuto.UnitTests.Helpers
{
    public class CustomBuilder : Builder<CustomBuilder, TestModel>
    {
        public CustomBuilder()
        {
            Entity.FirstName = "Test FirstName";
        }
    }
}
