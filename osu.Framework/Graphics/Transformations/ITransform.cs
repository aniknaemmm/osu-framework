﻿// Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System.Collections.Generic;
using osu.Framework.Lists;

namespace osu.Framework.Graphics.Transformations
{
    public interface ITransform : IHasLifetime
    {
        double Duration { get; }

        double StartTime { get; set; }
        double EndTime { get; set; }

        void Apply(Drawable d);

        ITransform Clone();
        ITransform CloneReverse();

        void Reverse();
        void Loop(double delay, int loopCount = -1);
    }

    public class TransformTimeComparer : IComparer<ITransform>
    {
        public int Compare(ITransform x, ITransform y)
        {
            int compare = x.StartTime.CompareTo(y.StartTime);
            if (compare != 0) return compare;
            compare = x.EndTime.CompareTo(y.EndTime);
            return compare;
        }
    }
}
