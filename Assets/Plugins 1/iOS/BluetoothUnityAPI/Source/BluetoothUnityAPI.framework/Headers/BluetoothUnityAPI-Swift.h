// Generated by Apple Swift version 5.1 (swiftlang-1100.0.270.13 clang-1100.0.33.7)
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wgcc-compat"

#if !defined(__has_include)
# define __has_include(x) 0
#endif
#if !defined(__has_attribute)
# define __has_attribute(x) 0
#endif
#if !defined(__has_feature)
# define __has_feature(x) 0
#endif
#if !defined(__has_warning)
# define __has_warning(x) 0
#endif

#if __has_include(<swift/objc-prologue.h>)
# include <swift/objc-prologue.h>
#endif

#pragma clang diagnostic ignored "-Wauto-import"
#include <Foundation/Foundation.h>
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>

#if !defined(SWIFT_TYPEDEFS)
# define SWIFT_TYPEDEFS 1
# if __has_include(<uchar.h>)
#  include <uchar.h>
# elif !defined(__cplusplus)
typedef uint_least16_t char16_t;
typedef uint_least32_t char32_t;
# endif
typedef float swift_float2  __attribute__((__ext_vector_type__(2)));
typedef float swift_float3  __attribute__((__ext_vector_type__(3)));
typedef float swift_float4  __attribute__((__ext_vector_type__(4)));
typedef double swift_double2  __attribute__((__ext_vector_type__(2)));
typedef double swift_double3  __attribute__((__ext_vector_type__(3)));
typedef double swift_double4  __attribute__((__ext_vector_type__(4)));
typedef int swift_int2  __attribute__((__ext_vector_type__(2)));
typedef int swift_int3  __attribute__((__ext_vector_type__(3)));
typedef int swift_int4  __attribute__((__ext_vector_type__(4)));
typedef unsigned int swift_uint2  __attribute__((__ext_vector_type__(2)));
typedef unsigned int swift_uint3  __attribute__((__ext_vector_type__(3)));
typedef unsigned int swift_uint4  __attribute__((__ext_vector_type__(4)));
#endif

#if !defined(SWIFT_PASTE)
# define SWIFT_PASTE_HELPER(x, y) x##y
# define SWIFT_PASTE(x, y) SWIFT_PASTE_HELPER(x, y)
#endif
#if !defined(SWIFT_METATYPE)
# define SWIFT_METATYPE(X) Class
#endif
#if !defined(SWIFT_CLASS_PROPERTY)
# if __has_feature(objc_class_property)
#  define SWIFT_CLASS_PROPERTY(...) __VA_ARGS__
# else
#  define SWIFT_CLASS_PROPERTY(...)
# endif
#endif

#if __has_attribute(objc_runtime_name)
# define SWIFT_RUNTIME_NAME(X) __attribute__((objc_runtime_name(X)))
#else
# define SWIFT_RUNTIME_NAME(X)
#endif
#if __has_attribute(swift_name)
# define SWIFT_COMPILE_NAME(X) __attribute__((swift_name(X)))
#else
# define SWIFT_COMPILE_NAME(X)
#endif
#if __has_attribute(objc_method_family)
# define SWIFT_METHOD_FAMILY(X) __attribute__((objc_method_family(X)))
#else
# define SWIFT_METHOD_FAMILY(X)
#endif
#if __has_attribute(noescape)
# define SWIFT_NOESCAPE __attribute__((noescape))
#else
# define SWIFT_NOESCAPE
#endif
#if __has_attribute(warn_unused_result)
# define SWIFT_WARN_UNUSED_RESULT __attribute__((warn_unused_result))
#else
# define SWIFT_WARN_UNUSED_RESULT
#endif
#if __has_attribute(noreturn)
# define SWIFT_NORETURN __attribute__((noreturn))
#else
# define SWIFT_NORETURN
#endif
#if !defined(SWIFT_CLASS_EXTRA)
# define SWIFT_CLASS_EXTRA
#endif
#if !defined(SWIFT_PROTOCOL_EXTRA)
# define SWIFT_PROTOCOL_EXTRA
#endif
#if !defined(SWIFT_ENUM_EXTRA)
# define SWIFT_ENUM_EXTRA
#endif
#if !defined(SWIFT_CLASS)
# if __has_attribute(objc_subclassing_restricted)
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# else
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# endif
#endif
#if !defined(SWIFT_RESILIENT_CLASS)
# if __has_attribute(objc_class_stub)
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME) __attribute__((objc_class_stub))
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_class_stub)) SWIFT_CLASS_NAMED(SWIFT_NAME)
# else
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME)
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) SWIFT_CLASS_NAMED(SWIFT_NAME)
# endif
#endif

#if !defined(SWIFT_PROTOCOL)
# define SWIFT_PROTOCOL(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
# define SWIFT_PROTOCOL_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
#endif

#if !defined(SWIFT_EXTENSION)
# define SWIFT_EXTENSION(M) SWIFT_PASTE(M##_Swift_, __LINE__)
#endif

#if !defined(OBJC_DESIGNATED_INITIALIZER)
# if __has_attribute(objc_designated_initializer)
#  define OBJC_DESIGNATED_INITIALIZER __attribute__((objc_designated_initializer))
# else
#  define OBJC_DESIGNATED_INITIALIZER
# endif
#endif
#if !defined(SWIFT_ENUM_ATTR)
# if defined(__has_attribute) && __has_attribute(enum_extensibility)
#  define SWIFT_ENUM_ATTR(_extensibility) __attribute__((enum_extensibility(_extensibility)))
# else
#  define SWIFT_ENUM_ATTR(_extensibility)
# endif
#endif
#if !defined(SWIFT_ENUM)
# define SWIFT_ENUM(_type, _name, _extensibility) enum _name : _type _name; enum SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# if __has_feature(generalized_swift_name)
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) enum _name : _type _name SWIFT_COMPILE_NAME(SWIFT_NAME); enum SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# else
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) SWIFT_ENUM(_type, _name, _extensibility)
# endif
#endif
#if !defined(SWIFT_UNAVAILABLE)
# define SWIFT_UNAVAILABLE __attribute__((unavailable))
#endif
#if !defined(SWIFT_UNAVAILABLE_MSG)
# define SWIFT_UNAVAILABLE_MSG(msg) __attribute__((unavailable(msg)))
#endif
#if !defined(SWIFT_AVAILABILITY)
# define SWIFT_AVAILABILITY(plat, ...) __attribute__((availability(plat, __VA_ARGS__)))
#endif
#if !defined(SWIFT_WEAK_IMPORT)
# define SWIFT_WEAK_IMPORT __attribute__((weak_import))
#endif
#if !defined(SWIFT_DEPRECATED)
# define SWIFT_DEPRECATED __attribute__((deprecated))
#endif
#if !defined(SWIFT_DEPRECATED_MSG)
# define SWIFT_DEPRECATED_MSG(...) __attribute__((deprecated(__VA_ARGS__)))
#endif
#if __has_feature(attribute_diagnose_if_objc)
# define SWIFT_DEPRECATED_OBJC(Msg) __attribute__((diagnose_if(1, Msg, "warning")))
#else
# define SWIFT_DEPRECATED_OBJC(Msg) SWIFT_DEPRECATED_MSG(Msg)
#endif
#if !defined(IBSegueAction)
# define IBSegueAction
#endif
#if __has_feature(modules)
#if __has_warning("-Watimport-in-framework-header")
#pragma clang diagnostic ignored "-Watimport-in-framework-header"
#endif
@import CoreBluetooth;
@import ObjectiveC;
#endif

#pragma clang diagnostic ignored "-Wproperty-attribute-mismatch"
#pragma clang diagnostic ignored "-Wduplicate-method-arg"
#if __has_warning("-Wpragma-clang-attribute")
# pragma clang diagnostic ignored "-Wpragma-clang-attribute"
#endif
#pragma clang diagnostic ignored "-Wunknown-pragmas"
#pragma clang diagnostic ignored "-Wnullability"

#if __has_attribute(external_source_symbol)
# pragma push_macro("any")
# undef any
# pragma clang attribute push(__attribute__((external_source_symbol(language="Swift", defined_in="BluetoothUnityAPI",generated_declaration))), apply_to=any(function,enum,objc_interface,objc_category,objc_protocol))
# pragma pop_macro("any")
#endif

@protocol IStreamManager;
@protocol BluetoothEventListener;
@class BluetoothDevice;
@class BluetoothHelperCharacteristic;
@class BluetoothHelperService;

SWIFT_CLASS("_TtC17BluetoothUnityAPI15BluetoothHelper")
@interface BluetoothHelper : NSObject
- (nullable instancetype)initWithDeviceName:(NSString * _Nonnull)deviceName error:(NSError * _Nullable * _Nullable)error OBJC_DESIGNATED_INITIALIZER;
- (BOOL)startListeningAndReturnError:(NSError * _Nullable * _Nullable)error;
- (BOOL)sendData:(NSString * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
- (BOOL)sendBData:(NSArray<NSNumber *> * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
- (void)Disconnect;
- (BOOL)ScanNearbyDevices SWIFT_WARN_UNUSED_RESULT;
- (BOOL)ConnectAndReturnError:(NSError * _Nullable * _Nullable)error;
- (BOOL)isConnected SWIFT_WARN_UNUSED_RESULT;
- (void)InvokeOnConnected;
- (void)setTerminatorBasedStream:(NSString * _Nonnull)separator;
- (void)setCustomStreamManager:(id <IStreamManager> _Nonnull)streamManager;
- (void)setBytesTerminatorBasedStream:(NSArray<NSNumber *> * _Nonnull)separator;
- (void)setLengthBasedStream;
- (void)setFixedLengthBasedStream:(NSInteger)length;
- (void)setOnEventReceivedListener:(id <BluetoothEventListener> _Nonnull)listener;
- (NSString * _Nullable)getDeviceName SWIFT_WARN_UNUSED_RESULT;
- (NSString * _Nullable)getDeviceAddress SWIFT_WARN_UNUSED_RESULT;
- (NSArray<BluetoothDevice *> * _Nonnull)getNearbyDevices SWIFT_WARN_UNUSED_RESULT;
- (NSString * _Nonnull)getBluetoothDeviceName SWIFT_WARN_UNUSED_RESULT;
- (NSString * _Nonnull)getBluetoothDeviceAddress SWIFT_WARN_UNUSED_RESULT;
- (BOOL)isDevicePaired SWIFT_WARN_UNUSED_RESULT;
- (void)setDeviceName:(NSString * _Nonnull)deviceName;
- (void)setDeviceAddress:(NSString * _Nonnull)deviceAddress;
- (NSInteger)getLastError SWIFT_WARN_UNUSED_RESULT;
- (BOOL)isBluetoothEnabled SWIFT_WARN_UNUSED_RESULT;
- (NSArray<BluetoothDevice *> * _Nullable)getPairedDevicesListAndReturnError:(NSError * _Nullable * _Nullable)error SWIFT_WARN_UNUSED_RESULT;
- (BOOL)subscribe:(BluetoothHelperCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable * _Nullable)error;
- (BOOL)writeCharacteristic:(BluetoothHelperCharacteristic * _Nonnull)characteristic :(NSArray<NSNumber *> * _Nonnull)value error:(NSError * _Nullable * _Nullable)error;
- (BOOL)readCharacteristic:(BluetoothHelperCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable * _Nullable)error;
- (BOOL)writeStringCharacteristic:(BluetoothHelperCharacteristic * _Nonnull)characteristic :(NSString * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
- (int16_t)getId SWIFT_WARN_UNUSED_RESULT;
- (BOOL)setTxCharacteristic:(NSString * _Nonnull)characteristic :(NSString * _Nonnull)service error:(NSError * _Nullable * _Nullable)error;
- (BOOL)setRxCharacteristic:(NSString * _Nonnull)characteristic :(NSString * _Nonnull)service error:(NSError * _Nullable * _Nullable)error;
- (NSArray<BluetoothHelperService *> * _Nullable)getGattServicesAndReturnError:(NSError * _Nullable * _Nullable)error SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end

@class CBCentralManager;
@class CBPeripheral;
@class NSNumber;
@class CBCharacteristic;
@class CBService;

SWIFT_CLASS("_TtC17BluetoothUnityAPI18BLEBluetoothHelper")
@interface BLEBluetoothHelper : BluetoothHelper <CBCentralManagerDelegate, CBPeripheralDelegate>
- (nullable instancetype)initWithDeviceName:(NSString * _Nonnull)deviceName error:(NSError * _Nullable * _Nullable)error OBJC_DESIGNATED_INITIALIZER;
- (BOOL)ScanNearbyDevices SWIFT_WARN_UNUSED_RESULT;
- (void)centralManager:(CBCentralManager * _Nonnull)central didDiscoverPeripheral:(CBPeripheral * _Nonnull)peripheral advertisementData:(NSDictionary<NSString *, id> * _Nonnull)advertisementData RSSI:(NSNumber * _Nonnull)RSSI;
- (void)centralManagerDidUpdateState:(CBCentralManager * _Nonnull)central;
- (void)centralManager:(CBCentralManager * _Nonnull)central didConnectPeripheral:(CBPeripheral * _Nonnull)peripheral;
- (void)centralManager:(CBCentralManager * _Nonnull)central didDisconnectPeripheral:(CBPeripheral * _Nonnull)peripheral error:(NSError * _Nullable)error;
- (CBCharacteristic * _Nullable)getTxCharacteristic SWIFT_WARN_UNUSED_RESULT;
- (CBPeripheral * _Nullable)getPeriferal SWIFT_WARN_UNUSED_RESULT;
- (void)centralManager:(CBCentralManager * _Nonnull)central didFailToConnectPeripheral:(CBPeripheral * _Nonnull)peripheral error:(NSError * _Nullable)error;
- (NSArray<BluetoothDevice *> * _Nullable)getPairedDevicesListAndReturnError:(NSError * _Nullable * _Nullable)error SWIFT_WARN_UNUSED_RESULT;
- (void)peripheral:(CBPeripheral * _Nonnull)peripheral didDiscoverServices:(NSError * _Nullable)error;
- (void)peripheral:(CBPeripheral * _Nonnull)peripheral didDiscoverCharacteristicsForService:(CBService * _Nonnull)service error:(NSError * _Nullable)error;
- (void)setDeviceAddress:(NSString * _Nonnull)deviceAddress;
- (BOOL)ConnectAndReturnError:(NSError * _Nullable * _Nullable)error;
- (BOOL)isBluetoothEnabled SWIFT_WARN_UNUSED_RESULT;
- (void)Disconnect;
- (void)peripheral:(CBPeripheral * _Nonnull)peripheral didUpdateNotificationStateForCharacteristic:(CBCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable)error;
- (void)peripheral:(CBPeripheral * _Nonnull)peripheral didUpdateValueForCharacteristic:(CBCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable)error;
- (BOOL)subscribe:(BluetoothHelperCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable * _Nullable)error;
- (BOOL)writeCharacteristic:(BluetoothHelperCharacteristic * _Nonnull)characteristic :(NSArray<NSNumber *> * _Nonnull)value error:(NSError * _Nullable * _Nullable)error;
- (BOOL)readCharacteristic:(BluetoothHelperCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable * _Nullable)error;
- (BOOL)setTxCharacteristic:(NSString * _Nonnull)characteristic :(NSString * _Nonnull)service error:(NSError * _Nullable * _Nullable)error;
- (BOOL)setRxCharacteristic:(NSString * _Nonnull)characteristic :(NSString * _Nonnull)service error:(NSError * _Nullable * _Nullable)error;
- (NSArray<BluetoothHelperService *> * _Nullable)getGattServicesAndReturnError:(NSError * _Nullable * _Nullable)error SWIFT_WARN_UNUSED_RESULT;
@end


SWIFT_PROTOCOL("_TtP17BluetoothUnityAPI20InvokeOnDataReceived_")
@protocol InvokeOnDataReceived
- (void)InvokeOnDataReceived:(NSArray<NSNumber *> * _Nonnull)buff;
@end


SWIFT_CLASS("_TtC17BluetoothUnityAPI22BluetoothStreamManager")
@interface BluetoothStreamManager : NSObject
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


SWIFT_CLASS("_TtC17BluetoothUnityAPI28BluetoothCustomStreamManager")
@interface BluetoothCustomStreamManager : BluetoothStreamManager <InvokeOnDataReceived>
- (nonnull instancetype)init:(BluetoothHelper * _Nonnull)helper :(id <IStreamManager> _Nonnull)streamManager OBJC_DESIGNATED_INITIALIZER;
- (void)sendData;
- (void)InvokeOnDataReceived:(NSArray<NSNumber *> * _Nonnull)buff;
@end


SWIFT_CLASS("_TtC17BluetoothUnityAPI15BluetoothDevice")
@interface BluetoothDevice : NSObject
- (nonnull instancetype)init:(NSString * _Nonnull)deviceName :(NSString * _Nonnull)deviceAddress OBJC_DESIGNATED_INITIALIZER;
- (NSString * _Nonnull)getDeviceName SWIFT_WARN_UNUSED_RESULT;
- (NSString * _Nonnull)getDeviceAddress SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


SWIFT_PROTOCOL("_TtP17BluetoothUnityAPI22BluetoothEventListener_")
@protocol BluetoothEventListener
- (void)OnDataReceived:(NSString * _Nonnull)data;
- (void)OnBinaryDataReceived:(NSArray<NSNumber *> * _Nonnull)data;
- (void)OnConnected;
- (void)OnConnectionFailed;
- (void)OnScanEnded;
- (void)OnServiceNotFound:(NSString * _Nonnull)service;
- (void)OnCharacteristicNotFound:(NSString * _Nonnull)service :(NSString * _Nonnull)characteristic;
- (void)OnCharacteristicChanged:(NSArray<NSNumber *> * _Nonnull)value :(BluetoothHelperCharacteristic * _Nonnull)characteristic;
@end



SWIFT_CLASS("_TtC17BluetoothUnityAPI29BluetoothHelperCharacteristic")
@interface BluetoothHelperCharacteristic : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init:(NSString * _Nonnull)name OBJC_DESIGNATED_INITIALIZER;
- (void)setName:(NSString * _Nonnull)name;
- (NSString * _Nonnull)getName SWIFT_WARN_UNUSED_RESULT;
- (void)setService:(NSString * _Nonnull)service;
- (NSString * _Nonnull)getService SWIFT_WARN_UNUSED_RESULT;
- (BOOL)isEqual:(id _Nullable)object SWIFT_WARN_UNUSED_RESULT;
@end


SWIFT_CLASS("_TtC17BluetoothUnityAPI22BluetoothHelperService")
@interface BluetoothHelperService : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init:(NSString * _Nonnull)name OBJC_DESIGNATED_INITIALIZER;
- (void)setName:(NSString * _Nonnull)name;
- (NSString * _Nonnull)getName SWIFT_WARN_UNUSED_RESULT;
- (BOOL)isEqual:(id _Nullable)object SWIFT_WARN_UNUSED_RESULT;
- (void)addCharacteristic:(BluetoothHelperCharacteristic * _Nonnull)characteristic;
- (NSArray<BluetoothHelperCharacteristic *> * _Nonnull)getCharacteristics SWIFT_WARN_UNUSED_RESULT;
@end



SWIFT_PROTOCOL("_TtP17BluetoothUnityAPI14IStreamManager_")
@protocol IStreamManager
- (NSArray<NSNumber *> * _Nonnull)formatDataToSend:(NSArray<NSNumber *> * _Nonnull)buff SWIFT_WARN_UNUSED_RESULT;
- (void)handleReceivedData:(NSArray<NSNumber *> * _Nonnull)buff;
- (void)setInvokeOnDataReceived:(id <InvokeOnDataReceived> _Nonnull)listener;
@end


#if __has_attribute(external_source_symbol)
# pragma clang attribute pop
#endif
#pragma clang diagnostic pop
