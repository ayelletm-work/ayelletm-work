using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace IO_Tech.client.Helpers
{


    public class EnumListItem
    {
        public object Value { get; set; }

        public string DisplayValue { get; set; }
    }

    public static class AttributeExtentions
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            var memberInfo = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault();

            if (memberInfo != null)
                return (TAttribute)memberInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault();
            return null;
        }
    }

    public class EnumListItemCollection<T> : ObservableCollection<EnumListItem> where T : struct
    {
        readonly ResourceManager _resourceManager;
        readonly CultureInfo _cultureInfo;
        readonly Type _enumType;
        readonly Type _resourceType;

        public EnumListItemCollection() : this(CultureInfo.CurrentUICulture)
        {
        }

        public EnumListItemCollection(CultureInfo cultureInfo)
        {
            if (!typeof(T).IsEnum)
                throw new NotSupportedException($"{typeof(T).Name} is not Enum!");

            _enumType = typeof(T);
            this._cultureInfo = cultureInfo;

            _resourceType = GetResourceTypeFromEnumType();
            if (_resourceType != null)
                _resourceManager = new ResourceManager(_resourceType.FullName ?? throw new InvalidOperationException(), _resourceType.Assembly);

            foreach (T item in Enum.GetValues(_enumType))
                Add(new EnumListItem() {Value = item, DisplayValue = GetEnumDisplayValue(item)});
        }

        Type GetResourceTypeFromEnumType()
        {
            var manifestResourceName =
                this._enumType.Assembly.GetManifestResourceNames().FirstOrDefault
                    (t => t.Contains(this._enumType.Name));

            if (!String.IsNullOrEmpty(manifestResourceName))
                return Type.GetType(manifestResourceName.Replace(".resources",
                        String.Empty), (a) => this._enumType.Assembly,
                    (a, n, i) => this._enumType.Assembly.GetType(n, false, i));
            return null;
        }

        String GetEnumDisplayValue(T item)
        {
            var value = default(String);

            if (_resourceManager != null)
                value = _resourceManager.GetString(item.ToString(), _cultureInfo);

            if (value == null)
            {
                var descriptionAttribute = (item as Enum).GetAttribute<DescriptionAttribute>();
                if (descriptionAttribute == null)
                    return item.ToString();
                return descriptionAttribute.Description;
            }

            return value;
        }
    }
}