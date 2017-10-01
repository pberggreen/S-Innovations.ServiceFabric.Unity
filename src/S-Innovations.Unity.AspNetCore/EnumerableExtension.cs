﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.ObjectBuilder;

namespace SInnovations.Unity.AspNetCore
{
    public class EnumerableExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            // Enumerable strategy
            Context.Strategies.AddNew<EnumerableResolutionStrategy>(
                UnityBuildStage.TypeMapping);

        }
    }
}
