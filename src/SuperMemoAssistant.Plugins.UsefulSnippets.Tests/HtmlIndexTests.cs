﻿#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   6/13/2020 3:03:56 PM
// Modified By:  james

#endregion


using Xunit;



namespace SuperMemoAssistant.Plugins.UsefulSnippets.Tests
{

  public class HtmlIndexTests
  {

    [Theory]
    [InlineData(2, 18)]
    [InlineData(7, 32)]
    [InlineData(21, 57)]
    [InlineData(24, 60)]
    [InlineData(25, 73)]
    public void ConvertTextIdxToHtmlIdxReturnsHtmlIdx(int textIdx, int expected)
    {

      const string input = "<html><body><h1>Title</h1><h3>Subtitle</h3><p>This is <b>COOL</b><BR><BR>hi</p></body></html>";
      int actual = CurrentElement.ConvertTextIdxToHtmlIdx(input, textIdx);
      Assert.Equal(expected, actual);

    }
  }
}
