
// stdafx.h : ��׼ϵͳ�����ļ��İ����ļ���
// ���Ǿ���ʹ�õ��������ĵ�
// �ض�����Ŀ�İ����ļ�

#pragma once

#ifndef VC_EXTRALEAN
#define VC_EXTRALEAN            // �� Windows ͷ���ų�����ʹ�õ�����
#endif

#include "targetver.h"

#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // ĳЩ CString ���캯��������ʽ��

// �ر� MFC ��ĳЩ�����������ɷ��ĺ��Եľ�����Ϣ������
#define _AFX_ALL_WARNINGS

#include <afxwin.h>         // MFC ��������ͱ�׼���
#include <afxext.h>         // MFC ��չ


#include <afxdisp.h>        // MFC �Զ�����



#ifndef _AFX_NO_OLE_SUPPORT
#include <afxdtctl.h>           // MFC �� Internet Explorer 4 �����ؼ���֧��
#endif
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>             // MFC �� Windows �����ؼ���֧��
#endif // _AFX_NO_AFXCMN_SUPPORT

#include <afxcontrolbars.h>     // �������Ϳؼ����� MFC ֧��
typedef unsigned (WINAPI *PBEGINTHREADEX_FUNC)(LPVOID lpParam);
typedef unsigned *PBEGINTHREADEX_ID;

#include "KSJImageZoomMode.Inc/KSJImageZoomMode.h"
#include "..\\..\\..\\KSJGigeVisionApi.Inc\\KSJ_GIGEVISION.h"
#include "..\\..\\..\\KSJGigeVisionApi.Inc\\KSJGigeVisionApi.h"
#include "opencv.Inc\opencv\cv.hpp"
#include "opencv.Inc\opencv\highgui.h"
#include "opencv.Inc\opencv\cxcore.hpp"


#ifdef _WIN64
#pragma comment( lib, "KSJImageZoomMode.Lib\\win32\\x64\\MT_KSJImageZoomMode_x64.Lib") 
#pragma comment( lib, "..\\..\\..\\KSJGigeVisionApi.lib\\win64\\MD_KSJGigeVisionApi_x64.lib" )
#pragma comment(lib, "opencv.Lib\\x64\\opencv_world300.lib")
#else
#pragma comment( lib, "KSJImageZoomMode.Lib\\win32\\x86\\MT_KSJImageZoomMode_x86.Lib") 
#pragma comment( lib, "..\\..\\..\\KSJGigeVisionApi.lib\\win32\\MD_KSJGigeVisionApi_x86.lib" )
#pragma comment(lib, "opencv.Lib\\x86\\opencv_world300.lib")

#endif

using namespace cv;




#ifdef _UNICODE
#if defined _M_IX86
#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='x86' publicKeyToken='6595b64144ccf1df' language='*'\"")
#elif defined _M_X64
#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='amd64' publicKeyToken='6595b64144ccf1df' language='*'\"")
#else
#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='*' publicKeyToken='6595b64144ccf1df' language='*'\"")
#endif
#endif


