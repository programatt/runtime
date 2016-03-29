// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
    /// <devdoc>
    ///    <para>Provides a type converter to convert
    ///       collection objects to and from various other representations.</para>
    /// </devdoc>
    public class CollectionConverter : TypeConverter
    {
        /// <devdoc>
        ///    <para>Converts the given
        ///       value object to the
        ///       specified destination type.</para>
        /// </devdoc>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
            {
                throw new ArgumentNullException(nameof(destinationType));
            }

            if (destinationType == typeof(string))
            {
                if (value is ICollection)
                {
                    return SR.Collection;
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <devdoc>
        ///    <para>
        ///        Gets a collection of properties for the type of array specified by the value parameter using
        ///        the specified context and attributes.
        ///    </para>
        /// </devdoc>
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return new PropertyDescriptorCollection(null);
        }

        /// <devdoc>
        ///    <para>Gets a value indicating whether this object supports properties.</para>
        /// </devdoc>
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return false;
        }
    }
}
