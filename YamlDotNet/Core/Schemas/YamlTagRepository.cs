﻿namespace YamlDotNet.Core.Schemas
{
    public static class YamlTagRepository
    {
        public const string Prefix = "tag:yaml.org,2002:";

        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2802432"/>
        /// <see href="https://yaml.org/type/map.html"/>
        /// </summary>
        public static readonly TagName Mapping = Prefix + "map";

        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2802662"/>
        /// <see href="https://yaml.org/type/seq.html"/>
        /// </summary>
        public static readonly TagName Sequence = Prefix + "seq";

        // TODO: Implement this later
        /// <summary>
        /// <see href="https://yaml.org/type/omap.html"/>
        /// </summary>
        public static readonly TagName OrderedMapping = Prefix + "omap";

        // TODO: Implement this later
        /// <summary>
        /// <see href="https://yaml.org/type/pairs.html"/>
        /// </summary>
        public static readonly TagName Pairs = Prefix + "pairs";

        // TODO: Implement this later
        /// <summary>
        /// <see href="https://yaml.org/type/set.html"/>
        /// </summary>
        public static readonly TagName Set = Prefix + "set";



        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2802842"/>
        /// <see href="https://yaml.org/type/str.html"/>
        /// </summary>
        public static readonly TagName String = Prefix + "str";

        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2803362"/>
        /// <see href="https://yaml.org/type/null.html"/>
        /// </summary>
        public static readonly TagName Null = Prefix + "null";

        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2803629"/>
        /// <see href="https://yaml.org/type/bool.html"/>
        /// </summary>
        public static readonly TagName Boolean = Prefix + "bool";
        //public static class Boolean
        //{
        //    public static readonly TagName Yaml12 = Prefix + "bool", true, s => bool.Parse(s.Value));


        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2803828"/>
        /// <see href="https://yaml.org/type/int.html"/>
        /// </summary>
        public static readonly TagName Integer = Prefix + "int";

        /// <summary>
        /// <see href="https://yaml.org/spec/1.2/spec.html#id2804092"/>
        /// <see href="https://yaml.org/type/float.html"/>
        /// </summary>
        public static readonly TagName FloatingPoint = Prefix + "float";



        // TODO: Implement this later
        /// <summary>
        /// <see href="https://yaml.org/type/binary.html"/>
        /// </summary>
        public static readonly TagName Binary = Prefix + "binary";

        // TODO: Review how this is currently implemented
        /// <summary>
        /// <see href="https://yaml.org/type/merge.html"/>
        /// </summary>
        public static readonly TagName Merge = Prefix + "merge";

        // TODO: Implement this later
        /// <summary>
        /// <see href="https://yaml.org/type/timestamp.html"/>
        /// </summary>
        public static readonly TagName Timestamp = Prefix + "timestamp";

        // TODO: Implement this later
        /// <summary>
        /// <see href="https://yaml.org/type/value.html"/>
        /// </summary>
        public static readonly TagName Value = Prefix + "value";
    }
}
