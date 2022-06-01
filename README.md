HTML Renderer [![CI](https://github.com/the-department-of-code/HTML-Renderer/actions/workflows/ci.yml/badge.svg)](https://github.com/the-department-of-code/HTML-Renderer/actions/workflows/ci.yml)
=============

A fork of [ArthurHub/HTML-Renderer](https://github.com/ArthurHub/HTML-Renderer) updated to .NET Standard / .NET 6.0.

Where possible, the assemblies target .NET Standard 2.0:
- HtmlRenderer
- HtmlRenderer.PdfSharpCore

and .NET 6.0 otherwise:
- HtmlRenderer.WinForms
- HtmlRenderer.WPF

Note that the code now depends upon [PdfSharpCore](https://github.com/ststeiger/PdfSharpCore) rather than [PdfSharp](https://github.com/empira/PDFsharp).
