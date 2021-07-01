

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.xx.xxxx */
/* at a redacted point in time
 */
/* Compiler settings for ../../edge_embedded_browser/client/win/current/webview2experimental.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 8.xx.xxxx 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif /* __RPCNDR_H_VERSION__ */


#ifndef __webview2experimental_h__
#define __webview2experimental_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __ICoreWebView2Experimental3_FWD_DEFINED__
#define __ICoreWebView2Experimental3_FWD_DEFINED__
typedef interface ICoreWebView2Experimental3 ICoreWebView2Experimental3;

#endif 	/* __ICoreWebView2Experimental3_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_FWD_DEFINED__
#define __ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalBrowserProcessExitedEventArgs ICoreWebView2ExperimentalBrowserProcessExitedEventArgs;

#endif 	/* __ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_FWD_DEFINED__
#define __ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalBrowserProcessExitedEventHandler ICoreWebView2ExperimentalBrowserProcessExitedEventHandler;

#endif 	/* __ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalCompositionController3_FWD_DEFINED__
#define __ICoreWebView2ExperimentalCompositionController3_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalCompositionController3 ICoreWebView2ExperimentalCompositionController3;

#endif 	/* __ICoreWebView2ExperimentalCompositionController3_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalCompositionController4_FWD_DEFINED__
#define __ICoreWebView2ExperimentalCompositionController4_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalCompositionController4 ICoreWebView2ExperimentalCompositionController4;

#endif 	/* __ICoreWebView2ExperimentalCompositionController4_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificate_FWD_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificate_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalClientCertificate ICoreWebView2ExperimentalClientCertificate;

#endif 	/* __ICoreWebView2ExperimentalClientCertificate_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalStringCollection_FWD_DEFINED__
#define __ICoreWebView2ExperimentalStringCollection_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalStringCollection ICoreWebView2ExperimentalStringCollection;

#endif 	/* __ICoreWebView2ExperimentalStringCollection_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificateCollection_FWD_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificateCollection_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalClientCertificateCollection ICoreWebView2ExperimentalClientCertificateCollection;

#endif 	/* __ICoreWebView2ExperimentalClientCertificateCollection_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalEnvironment3_FWD_DEFINED__
#define __ICoreWebView2ExperimentalEnvironment3_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalEnvironment3 ICoreWebView2ExperimentalEnvironment3;

#endif 	/* __ICoreWebView2ExperimentalEnvironment3_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalSettings5_FWD_DEFINED__
#define __ICoreWebView2ExperimentalSettings5_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalSettings5 ICoreWebView2ExperimentalSettings5;

#endif 	/* __ICoreWebView2ExperimentalSettings5_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_FWD_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalClientCertificateRequestedEventArgs ICoreWebView2ExperimentalClientCertificateRequestedEventArgs;

#endif 	/* __ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_FWD_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalClientCertificateRequestedEventHandler ICoreWebView2ExperimentalClientCertificateRequestedEventHandler;

#endif 	/* __ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_FWD_DEFINED__
#define __ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler;

#endif 	/* __ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalUpdateRuntimeResult_FWD_DEFINED__
#define __ICoreWebView2ExperimentalUpdateRuntimeResult_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalUpdateRuntimeResult ICoreWebView2ExperimentalUpdateRuntimeResult;

#endif 	/* __ICoreWebView2ExperimentalUpdateRuntimeResult_FWD_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalEnvironment4_FWD_DEFINED__
#define __ICoreWebView2ExperimentalEnvironment4_FWD_DEFINED__
typedef interface ICoreWebView2ExperimentalEnvironment4 ICoreWebView2ExperimentalEnvironment4;

#endif 	/* __ICoreWebView2ExperimentalEnvironment4_FWD_DEFINED__ */


/* header files for imported files */
#include "webview2.h"

#ifdef __cplusplus
extern "C"{
#endif 



#ifndef __WebView2Experimental_LIBRARY_DEFINED__
#define __WebView2Experimental_LIBRARY_DEFINED__

/* library WebView2Experimental */
/* [version][uuid] */ 















typedef struct COREWEBVIEW2_MATRIX_4X4
    {
    FLOAT _11;
    FLOAT _12;
    FLOAT _13;
    FLOAT _14;
    FLOAT _21;
    FLOAT _22;
    FLOAT _23;
    FLOAT _24;
    FLOAT _31;
    FLOAT _32;
    FLOAT _33;
    FLOAT _34;
    FLOAT _41;
    FLOAT _42;
    FLOAT _43;
    FLOAT _44;
    } 	COREWEBVIEW2_MATRIX_4X4;

typedef /* [v1_enum] */ 
enum COREWEBVIEW2_UPDATE_RUNTIME_STATUS
    {
        COREWEBVIEW2_UPDATE_RUNTIME_STATUS_LATEST_VERSION_INSTALLED	= 0,
        COREWEBVIEW2_UPDATE_RUNTIME_STATUS_UPDATE_ALREADY_RUNNING	= ( COREWEBVIEW2_UPDATE_RUNTIME_STATUS_LATEST_VERSION_INSTALLED + 1 ) ,
        COREWEBVIEW2_UPDATE_RUNTIME_STATUS_BLOCKED_BY_POLICY	= ( COREWEBVIEW2_UPDATE_RUNTIME_STATUS_UPDATE_ALREADY_RUNNING + 1 ) ,
        COREWEBVIEW2_UPDATE_RUNTIME_STATUS_FAILED	= ( COREWEBVIEW2_UPDATE_RUNTIME_STATUS_BLOCKED_BY_POLICY + 1 ) 
    } 	COREWEBVIEW2_UPDATE_RUNTIME_STATUS;

typedef /* [v1_enum] */ 
enum COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND
    {
        COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND_NORMAL	= 0,
        COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND_FAILED	= ( COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND_NORMAL + 1 ) 
    } 	COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND;

typedef /* [v1_enum] */ 
enum COREWEBVIEW2_CLIENT_CERTIFICATE_KIND
    {
        COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_SMART_CARD	= 0,
        COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_PIN	= ( COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_SMART_CARD + 1 ) ,
        COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_OTHER	= ( COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_PIN + 1 ) 
    } 	COREWEBVIEW2_CLIENT_CERTIFICATE_KIND;


EXTERN_C const IID LIBID_WebView2Experimental;

#ifndef __ICoreWebView2Experimental3_INTERFACE_DEFINED__
#define __ICoreWebView2Experimental3_INTERFACE_DEFINED__

/* interface ICoreWebView2Experimental3 */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2Experimental3 = {0xf811aa06,0xbcc3,0x11eb,{0x85,0x29,0x02,0x42,0xac,0x13,0x00,0x03}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("f811aa06-bcc3-11eb-8529-0242ac130003")
    ICoreWebView2Experimental3 : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE add_ClientCertificateRequested( 
            /* [in] */ ICoreWebView2ExperimentalClientCertificateRequestedEventHandler *eventHandler,
            /* [out] */ EventRegistrationToken *token) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE remove_ClientCertificateRequested( 
            /* [in] */ EventRegistrationToken token) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2Experimental3Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2Experimental3 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2Experimental3 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2Experimental3 * This);
        
        HRESULT ( STDMETHODCALLTYPE *add_ClientCertificateRequested )( 
            ICoreWebView2Experimental3 * This,
            /* [in] */ ICoreWebView2ExperimentalClientCertificateRequestedEventHandler *eventHandler,
            /* [out] */ EventRegistrationToken *token);
        
        HRESULT ( STDMETHODCALLTYPE *remove_ClientCertificateRequested )( 
            ICoreWebView2Experimental3 * This,
            /* [in] */ EventRegistrationToken token);
        
        END_INTERFACE
    } ICoreWebView2Experimental3Vtbl;

    interface ICoreWebView2Experimental3
    {
        CONST_VTBL struct ICoreWebView2Experimental3Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2Experimental3_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2Experimental3_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2Experimental3_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2Experimental3_add_ClientCertificateRequested(This,eventHandler,token)	\
    ( (This)->lpVtbl -> add_ClientCertificateRequested(This,eventHandler,token) ) 

#define ICoreWebView2Experimental3_remove_ClientCertificateRequested(This,token)	\
    ( (This)->lpVtbl -> remove_ClientCertificateRequested(This,token) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2Experimental3_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalBrowserProcessExitedEventArgs */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalBrowserProcessExitedEventArgs = {0x1f00663f,0xaf8c,0x4782,{0x9c,0xdd,0xdd,0x01,0xc5,0x2e,0x34,0xcb}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("1f00663f-af8c-4782-9cdd-dd01c52e34cb")
    ICoreWebView2ExperimentalBrowserProcessExitedEventArgs : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_BrowserProcessExitKind( 
            /* [retval][out] */ COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND *browserProcessExitKind) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_BrowserProcessId( 
            /* [retval][out] */ UINT32 *value) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalBrowserProcessExitedEventArgsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventArgs * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventArgs * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventArgs * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_BrowserProcessExitKind )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventArgs * This,
            /* [retval][out] */ COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND *browserProcessExitKind);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_BrowserProcessId )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventArgs * This,
            /* [retval][out] */ UINT32 *value);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalBrowserProcessExitedEventArgsVtbl;

    interface ICoreWebView2ExperimentalBrowserProcessExitedEventArgs
    {
        CONST_VTBL struct ICoreWebView2ExperimentalBrowserProcessExitedEventArgsVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_get_BrowserProcessExitKind(This,browserProcessExitKind)	\
    ( (This)->lpVtbl -> get_BrowserProcessExitKind(This,browserProcessExitKind) ) 

#define ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_get_BrowserProcessId(This,value)	\
    ( (This)->lpVtbl -> get_BrowserProcessId(This,value) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalBrowserProcessExitedEventArgs_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalBrowserProcessExitedEventHandler */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalBrowserProcessExitedEventHandler = {0xfa504257,0xa216,0x4911,{0xa8,0x60,0xfe,0x88,0x25,0x71,0x28,0x61}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("fa504257-a216-4911-a860-fe8825712861")
    ICoreWebView2ExperimentalBrowserProcessExitedEventHandler : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE Invoke( 
            /* [in] */ ICoreWebView2Environment *sender,
            /* [in] */ ICoreWebView2ExperimentalBrowserProcessExitedEventArgs *args) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalBrowserProcessExitedEventHandlerVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventHandler * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventHandler * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventHandler * This);
        
        HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            ICoreWebView2ExperimentalBrowserProcessExitedEventHandler * This,
            /* [in] */ ICoreWebView2Environment *sender,
            /* [in] */ ICoreWebView2ExperimentalBrowserProcessExitedEventArgs *args);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalBrowserProcessExitedEventHandlerVtbl;

    interface ICoreWebView2ExperimentalBrowserProcessExitedEventHandler
    {
        CONST_VTBL struct ICoreWebView2ExperimentalBrowserProcessExitedEventHandlerVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_Invoke(This,sender,args)	\
    ( (This)->lpVtbl -> Invoke(This,sender,args) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalBrowserProcessExitedEventHandler_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalCompositionController3_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalCompositionController3_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalCompositionController3 */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalCompositionController3 = {0xb134916b,0xa104,0x4d2a,{0x95,0x67,0xc2,0xfd,0x53,0x71,0x43,0x50}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("b134916b-a104-4d2a-9567-c2fd53714350")
    ICoreWebView2ExperimentalCompositionController3 : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE DragEnter( 
            /* [in] */ IDataObject *dataObject,
            /* [in] */ DWORD keyState,
            /* [in] */ POINT point,
            /* [retval][out] */ DWORD *effect) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE DragLeave( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE DragOver( 
            /* [in] */ DWORD keyState,
            /* [in] */ POINT point,
            /* [retval][out] */ DWORD *effect) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE Drop( 
            /* [in] */ IDataObject *dataObject,
            /* [in] */ DWORD keyState,
            /* [in] */ POINT point,
            /* [retval][out] */ DWORD *effect) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalCompositionController3Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalCompositionController3 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalCompositionController3 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalCompositionController3 * This);
        
        HRESULT ( STDMETHODCALLTYPE *DragEnter )( 
            ICoreWebView2ExperimentalCompositionController3 * This,
            /* [in] */ IDataObject *dataObject,
            /* [in] */ DWORD keyState,
            /* [in] */ POINT point,
            /* [retval][out] */ DWORD *effect);
        
        HRESULT ( STDMETHODCALLTYPE *DragLeave )( 
            ICoreWebView2ExperimentalCompositionController3 * This);
        
        HRESULT ( STDMETHODCALLTYPE *DragOver )( 
            ICoreWebView2ExperimentalCompositionController3 * This,
            /* [in] */ DWORD keyState,
            /* [in] */ POINT point,
            /* [retval][out] */ DWORD *effect);
        
        HRESULT ( STDMETHODCALLTYPE *Drop )( 
            ICoreWebView2ExperimentalCompositionController3 * This,
            /* [in] */ IDataObject *dataObject,
            /* [in] */ DWORD keyState,
            /* [in] */ POINT point,
            /* [retval][out] */ DWORD *effect);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalCompositionController3Vtbl;

    interface ICoreWebView2ExperimentalCompositionController3
    {
        CONST_VTBL struct ICoreWebView2ExperimentalCompositionController3Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalCompositionController3_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalCompositionController3_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalCompositionController3_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalCompositionController3_DragEnter(This,dataObject,keyState,point,effect)	\
    ( (This)->lpVtbl -> DragEnter(This,dataObject,keyState,point,effect) ) 

#define ICoreWebView2ExperimentalCompositionController3_DragLeave(This)	\
    ( (This)->lpVtbl -> DragLeave(This) ) 

#define ICoreWebView2ExperimentalCompositionController3_DragOver(This,keyState,point,effect)	\
    ( (This)->lpVtbl -> DragOver(This,keyState,point,effect) ) 

#define ICoreWebView2ExperimentalCompositionController3_Drop(This,dataObject,keyState,point,effect)	\
    ( (This)->lpVtbl -> Drop(This,dataObject,keyState,point,effect) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalCompositionController3_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalCompositionController4_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalCompositionController4_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalCompositionController4 */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalCompositionController4 = {0xe6041d7f,0x18ac,0x4654,{0xa0,0x4e,0x8b,0x3f,0x81,0x25,0x1c,0x33}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("e6041d7f-18ac-4654-a04e-8b3f81251c33")
    ICoreWebView2ExperimentalCompositionController4 : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_UIAProvider( 
            /* [retval][out] */ IUnknown **provider) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE CreateCoreWebView2PointerInfoFromPointerId( 
            /* [in] */ UINT pointerId,
            /* [in] */ HWND parentWindow,
            /* [in] */ struct COREWEBVIEW2_MATRIX_4X4 transform,
            /* [retval][out] */ ICoreWebView2PointerInfo **pointerInfo) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalCompositionController4Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalCompositionController4 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalCompositionController4 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalCompositionController4 * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_UIAProvider )( 
            ICoreWebView2ExperimentalCompositionController4 * This,
            /* [retval][out] */ IUnknown **provider);
        
        HRESULT ( STDMETHODCALLTYPE *CreateCoreWebView2PointerInfoFromPointerId )( 
            ICoreWebView2ExperimentalCompositionController4 * This,
            /* [in] */ UINT pointerId,
            /* [in] */ HWND parentWindow,
            /* [in] */ struct COREWEBVIEW2_MATRIX_4X4 transform,
            /* [retval][out] */ ICoreWebView2PointerInfo **pointerInfo);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalCompositionController4Vtbl;

    interface ICoreWebView2ExperimentalCompositionController4
    {
        CONST_VTBL struct ICoreWebView2ExperimentalCompositionController4Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalCompositionController4_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalCompositionController4_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalCompositionController4_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalCompositionController4_get_UIAProvider(This,provider)	\
    ( (This)->lpVtbl -> get_UIAProvider(This,provider) ) 

#define ICoreWebView2ExperimentalCompositionController4_CreateCoreWebView2PointerInfoFromPointerId(This,pointerId,parentWindow,transform,pointerInfo)	\
    ( (This)->lpVtbl -> CreateCoreWebView2PointerInfoFromPointerId(This,pointerId,parentWindow,transform,pointerInfo) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalCompositionController4_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificate_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificate_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalClientCertificate */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalClientCertificate = {0xe7188076,0xbcc3,0x11eb,{0x85,0x29,0x02,0x42,0xac,0x13,0x00,0x03}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("e7188076-bcc3-11eb-8529-0242ac130003")
    ICoreWebView2ExperimentalClientCertificate : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Subject( 
            /* [retval][out] */ LPWSTR *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Issuer( 
            /* [retval][out] */ LPWSTR *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_ValidFrom( 
            /* [retval][out] */ double *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_ValidTo( 
            /* [retval][out] */ double *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_DerEncodedSerialNumber( 
            /* [retval][out] */ LPWSTR *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_DisplayName( 
            /* [retval][out] */ LPWSTR *value) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ToPemEncoding( 
            /* [retval][out] */ LPWSTR *pemEncodedData) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_PemEncodedIssuerCertificateChain( 
            /* [retval][out] */ ICoreWebView2ExperimentalStringCollection **value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Kind( 
            /* [retval][out] */ COREWEBVIEW2_CLIENT_CERTIFICATE_KIND *value) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalClientCertificateVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalClientCertificate * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalClientCertificate * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Subject )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ LPWSTR *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Issuer )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ LPWSTR *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_ValidFrom )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ double *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_ValidTo )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ double *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_DerEncodedSerialNumber )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ LPWSTR *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_DisplayName )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ LPWSTR *value);
        
        HRESULT ( STDMETHODCALLTYPE *ToPemEncoding )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ LPWSTR *pemEncodedData);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_PemEncodedIssuerCertificateChain )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ ICoreWebView2ExperimentalStringCollection **value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Kind )( 
            ICoreWebView2ExperimentalClientCertificate * This,
            /* [retval][out] */ COREWEBVIEW2_CLIENT_CERTIFICATE_KIND *value);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalClientCertificateVtbl;

    interface ICoreWebView2ExperimentalClientCertificate
    {
        CONST_VTBL struct ICoreWebView2ExperimentalClientCertificateVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalClientCertificate_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalClientCertificate_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalClientCertificate_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalClientCertificate_get_Subject(This,value)	\
    ( (This)->lpVtbl -> get_Subject(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_Issuer(This,value)	\
    ( (This)->lpVtbl -> get_Issuer(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_ValidFrom(This,value)	\
    ( (This)->lpVtbl -> get_ValidFrom(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_ValidTo(This,value)	\
    ( (This)->lpVtbl -> get_ValidTo(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_DerEncodedSerialNumber(This,value)	\
    ( (This)->lpVtbl -> get_DerEncodedSerialNumber(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_DisplayName(This,value)	\
    ( (This)->lpVtbl -> get_DisplayName(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_ToPemEncoding(This,pemEncodedData)	\
    ( (This)->lpVtbl -> ToPemEncoding(This,pemEncodedData) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_PemEncodedIssuerCertificateChain(This,value)	\
    ( (This)->lpVtbl -> get_PemEncodedIssuerCertificateChain(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificate_get_Kind(This,value)	\
    ( (This)->lpVtbl -> get_Kind(This,value) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalClientCertificate_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalStringCollection_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalStringCollection_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalStringCollection */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalStringCollection = {0xf41f3f8a,0xbcc3,0x11eb,{0x85,0x29,0x02,0x42,0xac,0x13,0x00,0x03}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("f41f3f8a-bcc3-11eb-8529-0242ac130003")
    ICoreWebView2ExperimentalStringCollection : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Count( 
            /* [retval][out] */ UINT *value) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetValueAtIndex( 
            /* [in] */ UINT index,
            /* [retval][out] */ LPWSTR *value) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalStringCollectionVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalStringCollection * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalStringCollection * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalStringCollection * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Count )( 
            ICoreWebView2ExperimentalStringCollection * This,
            /* [retval][out] */ UINT *value);
        
        HRESULT ( STDMETHODCALLTYPE *GetValueAtIndex )( 
            ICoreWebView2ExperimentalStringCollection * This,
            /* [in] */ UINT index,
            /* [retval][out] */ LPWSTR *value);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalStringCollectionVtbl;

    interface ICoreWebView2ExperimentalStringCollection
    {
        CONST_VTBL struct ICoreWebView2ExperimentalStringCollectionVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalStringCollection_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalStringCollection_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalStringCollection_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalStringCollection_get_Count(This,value)	\
    ( (This)->lpVtbl -> get_Count(This,value) ) 

#define ICoreWebView2ExperimentalStringCollection_GetValueAtIndex(This,index,value)	\
    ( (This)->lpVtbl -> GetValueAtIndex(This,index,value) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalStringCollection_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificateCollection_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificateCollection_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalClientCertificateCollection */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalClientCertificateCollection = {0xef5674d2,0xbcc3,0x11eb,{0x85,0x29,0x02,0x42,0xac,0x13,0x00,0x03}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("ef5674d2-bcc3-11eb-8529-0242ac130003")
    ICoreWebView2ExperimentalClientCertificateCollection : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Count( 
            /* [retval][out] */ UINT *value) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetValueAtIndex( 
            /* [in] */ UINT index,
            /* [retval][out] */ ICoreWebView2ExperimentalClientCertificate **certificate) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalClientCertificateCollectionVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalClientCertificateCollection * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalClientCertificateCollection * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalClientCertificateCollection * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Count )( 
            ICoreWebView2ExperimentalClientCertificateCollection * This,
            /* [retval][out] */ UINT *value);
        
        HRESULT ( STDMETHODCALLTYPE *GetValueAtIndex )( 
            ICoreWebView2ExperimentalClientCertificateCollection * This,
            /* [in] */ UINT index,
            /* [retval][out] */ ICoreWebView2ExperimentalClientCertificate **certificate);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalClientCertificateCollectionVtbl;

    interface ICoreWebView2ExperimentalClientCertificateCollection
    {
        CONST_VTBL struct ICoreWebView2ExperimentalClientCertificateCollectionVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalClientCertificateCollection_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalClientCertificateCollection_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalClientCertificateCollection_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalClientCertificateCollection_get_Count(This,value)	\
    ( (This)->lpVtbl -> get_Count(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateCollection_GetValueAtIndex(This,index,certificate)	\
    ( (This)->lpVtbl -> GetValueAtIndex(This,index,certificate) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalClientCertificateCollection_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalEnvironment3_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalEnvironment3_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalEnvironment3 */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalEnvironment3 = {0x9A2BE885,0x7F0B,0x4B26,{0xB6,0xDD,0xC9,0x69,0xBA,0xA0,0x0B,0xF1}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("9A2BE885-7F0B-4B26-B6DD-C969BAA00BF1")
    ICoreWebView2ExperimentalEnvironment3 : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE UpdateRuntime( 
            /* [in] */ ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler *handler) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalEnvironment3Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalEnvironment3 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalEnvironment3 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalEnvironment3 * This);
        
        HRESULT ( STDMETHODCALLTYPE *UpdateRuntime )( 
            ICoreWebView2ExperimentalEnvironment3 * This,
            /* [in] */ ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler *handler);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalEnvironment3Vtbl;

    interface ICoreWebView2ExperimentalEnvironment3
    {
        CONST_VTBL struct ICoreWebView2ExperimentalEnvironment3Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalEnvironment3_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalEnvironment3_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalEnvironment3_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalEnvironment3_UpdateRuntime(This,handler)	\
    ( (This)->lpVtbl -> UpdateRuntime(This,handler) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalEnvironment3_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalSettings5_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalSettings5_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalSettings5 */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalSettings5 = {0x45b1f964,0xf703,0x47ac,{0xa1,0x9a,0xb5,0x89,0xdd,0x0c,0x55,0x59}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("45b1f964-f703-47ac-a19a-b589dd0c5559")
    ICoreWebView2ExperimentalSettings5 : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_IsSwipeNavigationEnabled( 
            /* [retval][out] */ BOOL *enabled) = 0;
        
        virtual /* [propput] */ HRESULT STDMETHODCALLTYPE put_IsSwipeNavigationEnabled( 
            /* [in] */ BOOL enabled) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalSettings5Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalSettings5 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalSettings5 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalSettings5 * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_IsSwipeNavigationEnabled )( 
            ICoreWebView2ExperimentalSettings5 * This,
            /* [retval][out] */ BOOL *enabled);
        
        /* [propput] */ HRESULT ( STDMETHODCALLTYPE *put_IsSwipeNavigationEnabled )( 
            ICoreWebView2ExperimentalSettings5 * This,
            /* [in] */ BOOL enabled);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalSettings5Vtbl;

    interface ICoreWebView2ExperimentalSettings5
    {
        CONST_VTBL struct ICoreWebView2ExperimentalSettings5Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalSettings5_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalSettings5_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalSettings5_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalSettings5_get_IsSwipeNavigationEnabled(This,enabled)	\
    ( (This)->lpVtbl -> get_IsSwipeNavigationEnabled(This,enabled) ) 

#define ICoreWebView2ExperimentalSettings5_put_IsSwipeNavigationEnabled(This,enabled)	\
    ( (This)->lpVtbl -> put_IsSwipeNavigationEnabled(This,enabled) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalSettings5_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalClientCertificateRequestedEventArgs */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalClientCertificateRequestedEventArgs = {0xbc59db28,0xbcc3,0x11eb,{0x85,0x29,0x02,0x42,0xac,0x13,0x00,0x03}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("bc59db28-bcc3-11eb-8529-0242ac130003")
    ICoreWebView2ExperimentalClientCertificateRequestedEventArgs : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Host( 
            /* [retval][out] */ LPWSTR *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Port( 
            /* [retval][out] */ int *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_IsProxy( 
            /* [retval][out] */ BOOL *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_AllowedCertificateAuthorities( 
            /* [retval][out] */ ICoreWebView2ExperimentalStringCollection **value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_MutuallyTrustedCertificates( 
            /* [retval][out] */ ICoreWebView2ExperimentalClientCertificateCollection **value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_SelectedCertificate( 
            /* [retval][out] */ ICoreWebView2ExperimentalClientCertificate **value) = 0;
        
        virtual /* [propput] */ HRESULT STDMETHODCALLTYPE put_SelectedCertificate( 
            /* [in] */ ICoreWebView2ExperimentalClientCertificate *value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Cancel( 
            /* [retval][out] */ BOOL *value) = 0;
        
        virtual /* [propput] */ HRESULT STDMETHODCALLTYPE put_Cancel( 
            /* [in] */ BOOL value) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Handled( 
            /* [retval][out] */ BOOL *value) = 0;
        
        virtual /* [propput] */ HRESULT STDMETHODCALLTYPE put_Handled( 
            /* [in] */ BOOL value) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetDeferral( 
            /* [retval][out] */ ICoreWebView2Deferral **deferral) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalClientCertificateRequestedEventArgsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Host )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ LPWSTR *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Port )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ int *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_IsProxy )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ BOOL *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_AllowedCertificateAuthorities )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ ICoreWebView2ExperimentalStringCollection **value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_MutuallyTrustedCertificates )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ ICoreWebView2ExperimentalClientCertificateCollection **value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_SelectedCertificate )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ ICoreWebView2ExperimentalClientCertificate **value);
        
        /* [propput] */ HRESULT ( STDMETHODCALLTYPE *put_SelectedCertificate )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [in] */ ICoreWebView2ExperimentalClientCertificate *value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Cancel )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ BOOL *value);
        
        /* [propput] */ HRESULT ( STDMETHODCALLTYPE *put_Cancel )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [in] */ BOOL value);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Handled )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ BOOL *value);
        
        /* [propput] */ HRESULT ( STDMETHODCALLTYPE *put_Handled )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [in] */ BOOL value);
        
        HRESULT ( STDMETHODCALLTYPE *GetDeferral )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventArgs * This,
            /* [retval][out] */ ICoreWebView2Deferral **deferral);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalClientCertificateRequestedEventArgsVtbl;

    interface ICoreWebView2ExperimentalClientCertificateRequestedEventArgs
    {
        CONST_VTBL struct ICoreWebView2ExperimentalClientCertificateRequestedEventArgsVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_Host(This,value)	\
    ( (This)->lpVtbl -> get_Host(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_Port(This,value)	\
    ( (This)->lpVtbl -> get_Port(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_IsProxy(This,value)	\
    ( (This)->lpVtbl -> get_IsProxy(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_AllowedCertificateAuthorities(This,value)	\
    ( (This)->lpVtbl -> get_AllowedCertificateAuthorities(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_MutuallyTrustedCertificates(This,value)	\
    ( (This)->lpVtbl -> get_MutuallyTrustedCertificates(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_SelectedCertificate(This,value)	\
    ( (This)->lpVtbl -> get_SelectedCertificate(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_put_SelectedCertificate(This,value)	\
    ( (This)->lpVtbl -> put_SelectedCertificate(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_Cancel(This,value)	\
    ( (This)->lpVtbl -> get_Cancel(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_put_Cancel(This,value)	\
    ( (This)->lpVtbl -> put_Cancel(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_get_Handled(This,value)	\
    ( (This)->lpVtbl -> get_Handled(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_put_Handled(This,value)	\
    ( (This)->lpVtbl -> put_Handled(This,value) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_GetDeferral(This,deferral)	\
    ( (This)->lpVtbl -> GetDeferral(This,deferral) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalClientCertificateRequestedEventArgs_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalClientCertificateRequestedEventHandler */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalClientCertificateRequestedEventHandler = {0xd7175ba2,0xbcc3,0x11eb,{0x85,0x29,0x02,0x42,0xac,0x13,0x00,0x03}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("d7175ba2-bcc3-11eb-8529-0242ac130003")
    ICoreWebView2ExperimentalClientCertificateRequestedEventHandler : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE Invoke( 
            /* [in] */ ICoreWebView2 *sender,
            /* [in] */ ICoreWebView2ExperimentalClientCertificateRequestedEventArgs *args) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalClientCertificateRequestedEventHandlerVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventHandler * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventHandler * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventHandler * This);
        
        HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            ICoreWebView2ExperimentalClientCertificateRequestedEventHandler * This,
            /* [in] */ ICoreWebView2 *sender,
            /* [in] */ ICoreWebView2ExperimentalClientCertificateRequestedEventArgs *args);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalClientCertificateRequestedEventHandlerVtbl;

    interface ICoreWebView2ExperimentalClientCertificateRequestedEventHandler
    {
        CONST_VTBL struct ICoreWebView2ExperimentalClientCertificateRequestedEventHandlerVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_Invoke(This,sender,args)	\
    ( (This)->lpVtbl -> Invoke(This,sender,args) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalClientCertificateRequestedEventHandler_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler = {0xF1D2D722,0x3721,0x499C,{0x87,0xF5,0x4C,0x40,0x52,0x60,0x69,0x7A}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("F1D2D722-3721-499C-87F5-4C405260697A")
    ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE Invoke( 
            /* [in] */ HRESULT errorCode,
            /* [in] */ ICoreWebView2ExperimentalUpdateRuntimeResult *result) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalUpdateRuntimeCompletedHandlerVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler * This);
        
        HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler * This,
            /* [in] */ HRESULT errorCode,
            /* [in] */ ICoreWebView2ExperimentalUpdateRuntimeResult *result);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalUpdateRuntimeCompletedHandlerVtbl;

    interface ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler
    {
        CONST_VTBL struct ICoreWebView2ExperimentalUpdateRuntimeCompletedHandlerVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_Invoke(This,errorCode,result)	\
    ( (This)->lpVtbl -> Invoke(This,errorCode,result) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalUpdateRuntimeResult_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalUpdateRuntimeResult_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalUpdateRuntimeResult */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalUpdateRuntimeResult = {0xDD503E49,0xAB19,0x47C0,{0xB2,0xAD,0x6D,0xDD,0x09,0xCC,0x3E,0x3A}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("DD503E49-AB19-47C0-B2AD-6DDD09CC3E3A")
    ICoreWebView2ExperimentalUpdateRuntimeResult : public IUnknown
    {
    public:
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Status( 
            /* [retval][out] */ COREWEBVIEW2_UPDATE_RUNTIME_STATUS *status) = 0;
        
        virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_ExtendedError( 
            /* [retval][out] */ HRESULT *error) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalUpdateRuntimeResultVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalUpdateRuntimeResult * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalUpdateRuntimeResult * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalUpdateRuntimeResult * This);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_Status )( 
            ICoreWebView2ExperimentalUpdateRuntimeResult * This,
            /* [retval][out] */ COREWEBVIEW2_UPDATE_RUNTIME_STATUS *status);
        
        /* [propget] */ HRESULT ( STDMETHODCALLTYPE *get_ExtendedError )( 
            ICoreWebView2ExperimentalUpdateRuntimeResult * This,
            /* [retval][out] */ HRESULT *error);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalUpdateRuntimeResultVtbl;

    interface ICoreWebView2ExperimentalUpdateRuntimeResult
    {
        CONST_VTBL struct ICoreWebView2ExperimentalUpdateRuntimeResultVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalUpdateRuntimeResult_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalUpdateRuntimeResult_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalUpdateRuntimeResult_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalUpdateRuntimeResult_get_Status(This,status)	\
    ( (This)->lpVtbl -> get_Status(This,status) ) 

#define ICoreWebView2ExperimentalUpdateRuntimeResult_get_ExtendedError(This,error)	\
    ( (This)->lpVtbl -> get_ExtendedError(This,error) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalUpdateRuntimeResult_INTERFACE_DEFINED__ */


#ifndef __ICoreWebView2ExperimentalEnvironment4_INTERFACE_DEFINED__
#define __ICoreWebView2ExperimentalEnvironment4_INTERFACE_DEFINED__

/* interface ICoreWebView2ExperimentalEnvironment4 */
/* [unique][object][uuid] */ 


EXTERN_C __declspec(selectany) const IID IID_ICoreWebView2ExperimentalEnvironment4 = {0x0204e16b,0x7bc8,0x4bdc,{0x94,0xd7,0x1e,0x70,0xc4,0xd1,0xa8,0xa7}};

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("0204e16b-7bc8-4bdc-94d7-1e70c4d1a8a7")
    ICoreWebView2ExperimentalEnvironment4 : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE add_BrowserProcessExited( 
            /* [in] */ ICoreWebView2ExperimentalBrowserProcessExitedEventHandler *eventHandler,
            /* [out] */ EventRegistrationToken *token) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE remove_BrowserProcessExited( 
            /* [in] */ EventRegistrationToken token) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICoreWebView2ExperimentalEnvironment4Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICoreWebView2ExperimentalEnvironment4 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICoreWebView2ExperimentalEnvironment4 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICoreWebView2ExperimentalEnvironment4 * This);
        
        HRESULT ( STDMETHODCALLTYPE *add_BrowserProcessExited )( 
            ICoreWebView2ExperimentalEnvironment4 * This,
            /* [in] */ ICoreWebView2ExperimentalBrowserProcessExitedEventHandler *eventHandler,
            /* [out] */ EventRegistrationToken *token);
        
        HRESULT ( STDMETHODCALLTYPE *remove_BrowserProcessExited )( 
            ICoreWebView2ExperimentalEnvironment4 * This,
            /* [in] */ EventRegistrationToken token);
        
        END_INTERFACE
    } ICoreWebView2ExperimentalEnvironment4Vtbl;

    interface ICoreWebView2ExperimentalEnvironment4
    {
        CONST_VTBL struct ICoreWebView2ExperimentalEnvironment4Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICoreWebView2ExperimentalEnvironment4_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICoreWebView2ExperimentalEnvironment4_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICoreWebView2ExperimentalEnvironment4_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICoreWebView2ExperimentalEnvironment4_add_BrowserProcessExited(This,eventHandler,token)	\
    ( (This)->lpVtbl -> add_BrowserProcessExited(This,eventHandler,token) ) 

#define ICoreWebView2ExperimentalEnvironment4_remove_BrowserProcessExited(This,token)	\
    ( (This)->lpVtbl -> remove_BrowserProcessExited(This,token) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICoreWebView2ExperimentalEnvironment4_INTERFACE_DEFINED__ */

#endif /* __WebView2Experimental_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


