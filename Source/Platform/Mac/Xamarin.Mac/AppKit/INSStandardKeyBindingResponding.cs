using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSStandardKeyBindingResponding", WrapperType = typeof(NSStandardKeyBindingRespondingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertText", Selector = "insertText:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DoCommandBySelector", Selector = "doCommandBySelector:", ParameterType = new Type[] { typeof(Selector) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveForward", Selector = "moveForward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveRight", Selector = "moveRight:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveBackward", Selector = "moveBackward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveLeft", Selector = "moveLeft:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveUp", Selector = "moveUp:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveDown", Selector = "moveDown:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordForward", Selector = "moveWordForward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordBackward", Selector = "moveWordBackward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToBeginningOfLine", Selector = "moveToBeginningOfLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToEndOfLine", Selector = "moveToEndOfLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToBeginningOfParagraph", Selector = "moveToBeginningOfParagraph:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToEndOfParagraph", Selector = "moveToEndOfParagraph:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToEndOfDocument", Selector = "moveToEndOfDocument:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToBeginningOfDocument", Selector = "moveToBeginningOfDocument:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageDown", Selector = "pageDown:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageUp", Selector = "pageUp:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CenterSelectionInVisibleArea", Selector = "centerSelectionInVisibleArea:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveBackwardAndModifySelection", Selector = "moveBackwardAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveForwardAndModifySelection", Selector = "moveForwardAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordForwardAndModifySelection", Selector = "moveWordForwardAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordBackwardAndModifySelection", Selector = "moveWordBackwardAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveUpAndModifySelection", Selector = "moveUpAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveDownAndModifySelection", Selector = "moveDownAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToBeginningOfLineAndModifySelection", Selector = "moveToBeginningOfLineAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToEndOfLineAndModifySelection", Selector = "moveToEndOfLineAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToBeginningOfParagraphAndModifySelection", Selector = "moveToBeginningOfParagraphAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToEndOfParagraphAndModifySelection", Selector = "moveToEndOfParagraphAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToEndOfDocumentAndModifySelection", Selector = "moveToEndOfDocumentAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToBeginningOfDocumentAndModifySelection", Selector = "moveToBeginningOfDocumentAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageDownAndModifySelection", Selector = "pageDownAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageUpAndModifySelection", Selector = "pageUpAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveParagraphForwardAndModifySelection", Selector = "moveParagraphForwardAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveParagraphBackwardAndModifySelection", Selector = "moveParagraphBackwardAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordRight", Selector = "moveWordRight:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordLeft", Selector = "moveWordLeft:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveRightAndModifySelection", Selector = "moveRightAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveLeftAndModifySelection", Selector = "moveLeftAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordRightAndModifySelection", Selector = "moveWordRightAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveWordLeftAndModifySelection", Selector = "moveWordLeftAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToLeftEndOfLine", Selector = "moveToLeftEndOfLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToRightEndOfLine", Selector = "moveToRightEndOfLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToLeftEndOfLineAndModifySelection", Selector = "moveToLeftEndOfLineAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveToRightEndOfLineAndModifySelection", Selector = "moveToRightEndOfLineAndModifySelection:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollPageUp", Selector = "scrollPageUp:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollPageDown", Selector = "scrollPageDown:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollLineUp", Selector = "scrollLineUp:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollLineDown", Selector = "scrollLineDown:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollToBeginningOfDocument", Selector = "scrollToBeginningOfDocument:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollToEndOfDocument", Selector = "scrollToEndOfDocument:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Transpose", Selector = "transpose:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransposeWords", Selector = "transposeWords:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectAll", Selector = "selectAll:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectParagraph", Selector = "selectParagraph:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectLine", Selector = "selectLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectWord", Selector = "selectWord:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Indent", Selector = "indent:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertTab", Selector = "insertTab:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertBacktab", Selector = "insertBacktab:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertNewline", Selector = "insertNewline:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertParagraphSeparator", Selector = "insertParagraphSeparator:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertNewlineIgnoringFieldEditor", Selector = "insertNewlineIgnoringFieldEditor:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertTabIgnoringFieldEditor", Selector = "insertTabIgnoringFieldEditor:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertLineBreak", Selector = "insertLineBreak:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertContainerBreak", Selector = "insertContainerBreak:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertSingleQuoteIgnoringSubstitution", Selector = "insertSingleQuoteIgnoringSubstitution:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertDoubleQuoteIgnoringSubstitution", Selector = "insertDoubleQuoteIgnoringSubstitution:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeCaseOfLetter", Selector = "changeCaseOfLetter:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UppercaseWord", Selector = "uppercaseWord:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LowercaseWord", Selector = "lowercaseWord:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CapitalizeWord", Selector = "capitalizeWord:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteForward", Selector = "deleteForward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteBackward", Selector = "deleteBackward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteBackwardByDecomposingPreviousCharacter", Selector = "deleteBackwardByDecomposingPreviousCharacter:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteWordForward", Selector = "deleteWordForward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteWordBackward", Selector = "deleteWordBackward:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteToBeginningOfLine", Selector = "deleteToBeginningOfLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteToEndOfLine", Selector = "deleteToEndOfLine:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteToBeginningOfParagraph", Selector = "deleteToBeginningOfParagraph:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteToEndOfParagraph", Selector = "deleteToEndOfParagraph:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Yank", Selector = "yank:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Complete", Selector = "complete:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMark", Selector = "setMark:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteToMark", Selector = "deleteToMark:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectToMark", Selector = "selectToMark:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SwapWithMark", Selector = "swapWithMark:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelOperation", Selector = "cancelOperation:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeBaseWritingDirectionNatural", Selector = "makeBaseWritingDirectionNatural:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeBaseWritingDirectionLeftToRight", Selector = "makeBaseWritingDirectionLeftToRight:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeBaseWritingDirectionRightToLeft", Selector = "makeBaseWritingDirectionRightToLeft:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeTextWritingDirectionNatural", Selector = "makeTextWritingDirectionNatural:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeTextWritingDirectionLeftToRight", Selector = "makeTextWritingDirectionLeftToRight:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeTextWritingDirectionRightToLeft", Selector = "makeTextWritingDirectionRightToLeft:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "QuickLookPreviewItems", Selector = "quickLookPreviewItems:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
public interface INSStandardKeyBindingResponding : INativeObject, IDisposable
{
}
