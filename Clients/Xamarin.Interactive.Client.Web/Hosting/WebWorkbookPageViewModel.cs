﻿//
// Author:
//   Aaron Bockover <abock@microsoft.com>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;

using Xamarin.Interactive.Workbook.Models;
using Xamarin.Interactive.Workbook.Views;

namespace Xamarin.Interactive.Client.Web.Hosting
{
    sealed class WebWorkbookPageViewModel : WorkbookPageViewModel
    {
        readonly IServiceProvider serviceProvider;
        readonly TextWriter output = Console.Out;

        public WebWorkbookPageViewModel (
            IServiceProvider serviceProvider,
            ClientSession clientSession,
            WorkbookPage workbookPage)
            : base (clientSession, workbookPage)
            => this.serviceProvider = serviceProvider;

        protected override void BindCodeCellToView (CodeCell cell, CodeCellState codeCellState)
        {
            var view = new WebCellView (cell, output);
            codeCellState.Editor = view.Editor;
            codeCellState.View = view;
            cell.View = view;
        }

        protected override void BindMarkdownCellToView (MarkdownCell cell)
            => cell.View = new WebCellView (cell, output);

        protected override void InsertCellInViewModel (Cell newCell, Cell previousCell)
        {
        }

        protected override void UnbindCellFromView (ICellView cellView)
        {
        }
    }
}