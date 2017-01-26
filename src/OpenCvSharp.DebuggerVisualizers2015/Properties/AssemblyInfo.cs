﻿using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyTitle("OpenCvSharp.DebuggerVisualizers2015")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("OpenCvSharp.DebuggerVisualizers2015")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、その型はこのアセンブリ内で COM コンポーネントから 
// 参照不可能になります。COM からこのアセンブリ内の型にアクセスする場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("b55bf2d4-6ed3-4f5d-a1af-134cee502b24")]

// アセンブリのバージョン情報は次の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      Revision
//
// すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を 
// 既定値にすることができます:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// OpenCvSharp objects' debugger visualizer
[assembly: DebuggerVisualizer(
    typeof(OpenCvSharp.DebuggerVisualizers2015.IplImageDebuggerVisualizer),
    typeof(OpenCvSharp.DebuggerVisualizers2015.IplImageObjectSource),
    Target = typeof(OpenCvSharp.IplImage),
    Description = "IplImage View Visualizer"
)]

[assembly: DebuggerVisualizer(
    typeof(OpenCvSharp.DebuggerVisualizers2015.CvMatDebuggerVisualizer),
    typeof(OpenCvSharp.DebuggerVisualizers2015.CvMatObjectSource),
    Target = typeof(OpenCvSharp.CvMat),
    Description = "CvMat View Visualizer"
)]

[assembly: DebuggerVisualizer(
    typeof(OpenCvSharp.DebuggerVisualizers2015.MatDebuggerVisualizer),
    typeof(OpenCvSharp.DebuggerVisualizers2015.MatObjectSource),
    Target = typeof(OpenCvSharp.CPlusPlus.Mat),
    Description = "Mat View Visualizer"
)]
