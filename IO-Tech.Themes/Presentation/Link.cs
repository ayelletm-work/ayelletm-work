﻿using System;

namespace IO_Tech.Themes.Presentation
{
    /// <summary>
    /// Represents a displayable link.
    /// </summary>
    public class Link
        : Displayable
    {
        private Uri source;

        /// <summary>
        /// Gets or sets the source uri.
        /// </summary>
        /// <value>The source.</value>
        public Uri Source
        {
            get => source;
            set
            {
                if (source != value) {
                    source = value;
                    OnPropertyChanged("Source");
                }
            }
        }
    }
}
