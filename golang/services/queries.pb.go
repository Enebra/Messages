// Code generated by protoc-gen-go.
// source: services/queries.proto
// DO NOT EDIT!

/*
Package Services is a generated protocol buffer package.

It is generated from these files:
	services/queries.proto

It has these top-level messages:
	GetPersonRequest
	GetLocationRequest
	GetVisitRecordRequest
	Page
	GetCardRequest
*/
package Services

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"
import DataTypes2 "datatypes"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion2 // please upgrade the proto package

type GetPersonRequest struct {
	SearchText string `protobuf:"bytes,1,opt,name=search_text,json=searchText" json:"search_text,omitempty"`
	FirstName  string `protobuf:"bytes,2,opt,name=first_name,json=firstName" json:"first_name,omitempty"`
	LastName   string `protobuf:"bytes,3,opt,name=last_name,json=lastName" json:"last_name,omitempty"`
	Card       string `protobuf:"bytes,4,opt,name=card" json:"card,omitempty"`
	// TODO Photo    photo
	// TODO Rights   rights
	Locations []string `protobuf:"bytes,5,rep,name=locations" json:"locations,omitempty"`
	Page      *Page    `protobuf:"bytes,6,opt,name=page" json:"page,omitempty"`
}

func (m *GetPersonRequest) Reset()                    { *m = GetPersonRequest{} }
func (m *GetPersonRequest) String() string            { return proto.CompactTextString(m) }
func (*GetPersonRequest) ProtoMessage()               {}
func (*GetPersonRequest) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

func (m *GetPersonRequest) GetPage() *Page {
	if m != nil {
		return m.Page
	}
	return nil
}

type GetLocationRequest struct {
	SearchText string `protobuf:"bytes,1,opt,name=search_text,json=searchText" json:"search_text,omitempty"`
	Name       string `protobuf:"bytes,2,opt,name=name" json:"name,omitempty"`
	MacAddress string `protobuf:"bytes,3,opt,name=mac_address,json=macAddress" json:"mac_address,omitempty"`
	DeviceName string `protobuf:"bytes,4,opt,name=device_name,json=deviceName" json:"device_name,omitempty"`
	Page       *Page  `protobuf:"bytes,5,opt,name=page" json:"page,omitempty"`
}

func (m *GetLocationRequest) Reset()                    { *m = GetLocationRequest{} }
func (m *GetLocationRequest) String() string            { return proto.CompactTextString(m) }
func (*GetLocationRequest) ProtoMessage()               {}
func (*GetLocationRequest) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

func (m *GetLocationRequest) GetPage() *Page {
	if m != nil {
		return m.Page
	}
	return nil
}

type GetVisitRecordRequest struct {
	SearchText   string                 `protobuf:"bytes,1,opt,name=search_text,json=searchText" json:"search_text,omitempty"`
	State        DataTypes2.AccessState `protobuf:"varint,2,opt,name=state,enum=DataTypes.AccessState" json:"state,omitempty"`
	Locations    []string               `protobuf:"bytes,3,rep,name=locations" json:"locations,omitempty"`
	Persons      []string               `protobuf:"bytes,4,rep,name=persons" json:"persons,omitempty"`
	DatetimeFrom int64                  `protobuf:"varint,5,opt,name=datetime_from,json=datetimeFrom" json:"datetime_from,omitempty"`
	DatetimeTo   int64                  `protobuf:"varint,6,opt,name=datetime_to,json=datetimeTo" json:"datetime_to,omitempty"`
	Card         string                 `protobuf:"bytes,7,opt,name=card" json:"card,omitempty"`
	Page         *Page                  `protobuf:"bytes,8,opt,name=page" json:"page,omitempty"`
}

func (m *GetVisitRecordRequest) Reset()                    { *m = GetVisitRecordRequest{} }
func (m *GetVisitRecordRequest) String() string            { return proto.CompactTextString(m) }
func (*GetVisitRecordRequest) ProtoMessage()               {}
func (*GetVisitRecordRequest) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{2} }

func (m *GetVisitRecordRequest) GetPage() *Page {
	if m != nil {
		return m.Page
	}
	return nil
}

type Page struct {
	Index int32 `protobuf:"varint,1,opt,name=index" json:"index,omitempty"`
	Size  int32 `protobuf:"varint,2,opt,name=size" json:"size,omitempty"`
}

func (m *Page) Reset()                    { *m = Page{} }
func (m *Page) String() string            { return proto.CompactTextString(m) }
func (*Page) ProtoMessage()               {}
func (*Page) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{3} }

type GetCardRequest struct {
	SearchText       string   `protobuf:"bytes,1,opt,name=search_text,json=searchText" json:"search_text,omitempty"`
	UniqueIdentifier string   `protobuf:"bytes,2,opt,name=unique_identifier,json=uniqueIdentifier" json:"unique_identifier,omitempty"`
	Owners           []string `protobuf:"bytes,3,rep,name=owners" json:"owners,omitempty"`
	Page             *Page    `protobuf:"bytes,4,opt,name=page" json:"page,omitempty"`
}

func (m *GetCardRequest) Reset()                    { *m = GetCardRequest{} }
func (m *GetCardRequest) String() string            { return proto.CompactTextString(m) }
func (*GetCardRequest) ProtoMessage()               {}
func (*GetCardRequest) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{4} }

func (m *GetCardRequest) GetPage() *Page {
	if m != nil {
		return m.Page
	}
	return nil
}

func init() {
	proto.RegisterType((*GetPersonRequest)(nil), "Services.GetPersonRequest")
	proto.RegisterType((*GetLocationRequest)(nil), "Services.GetLocationRequest")
	proto.RegisterType((*GetVisitRecordRequest)(nil), "Services.GetVisitRecordRequest")
	proto.RegisterType((*Page)(nil), "Services.Page")
	proto.RegisterType((*GetCardRequest)(nil), "Services.GetCardRequest")
}

func init() { proto.RegisterFile("services/queries.proto", fileDescriptor0) }

var fileDescriptor0 = []byte{
	// 477 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0x94, 0x53, 0xdd, 0x6a, 0xd4, 0x40,
	0x14, 0x26, 0x4d, 0xb2, 0x3f, 0xa7, 0xba, 0xd6, 0x41, 0x97, 0xa0, 0x15, 0x97, 0xf5, 0xa6, 0xa0,
	0xa4, 0x52, 0x9f, 0xa0, 0x2a, 0x06, 0x41, 0xa4, 0x4c, 0x17, 0x6f, 0xc3, 0x38, 0x39, 0xbb, 0x0e,
	0x34, 0x99, 0xec, 0xcc, 0xd9, 0xba, 0xfa, 0x28, 0xe2, 0x95, 0x2f, 0xe0, 0x53, 0xf8, 0x5e, 0x32,
	0x33, 0xc9, 0x52, 0x05, 0x4b, 0xbd, 0x9b, 0xf3, 0x7d, 0x67, 0x86, 0xef, 0x27, 0x81, 0xa9, 0x45,
	0x73, 0xa9, 0x24, 0xda, 0xe3, 0xf5, 0x06, 0x8d, 0x42, 0x9b, 0xb7, 0x46, 0x93, 0x66, 0xa3, 0xf3,
	0x0e, 0x7f, 0x70, 0x58, 0x09, 0x12, 0xf4, 0xa5, 0x45, 0x7b, 0x7c, 0xa9, 0xac, 0xa2, 0xd2, 0xa0,
	0xd4, 0xa6, 0x0a, 0x7b, 0xf3, 0x5f, 0x11, 0x1c, 0x14, 0x48, 0x67, 0x68, 0xac, 0x6e, 0x38, 0xae,
	0x37, 0x68, 0x89, 0x3d, 0x86, 0x7d, 0x8b, 0xc2, 0xc8, 0x4f, 0x25, 0xe1, 0x96, 0xb2, 0x68, 0x16,
	0x1d, 0x8d, 0x39, 0x04, 0x68, 0x81, 0x5b, 0x62, 0x8f, 0x00, 0x96, 0xca, 0x58, 0x2a, 0x1b, 0x51,
	0x63, 0xb6, 0xe7, 0xf9, 0xb1, 0x47, 0xde, 0x8b, 0x1a, 0xd9, 0x43, 0x18, 0x5f, 0x88, 0x9e, 0x8d,
	0x3d, 0x3b, 0x72, 0x80, 0x27, 0x19, 0x24, 0x52, 0x98, 0x2a, 0x4b, 0x3c, 0xee, 0xcf, 0xec, 0x10,
	0xc6, 0x17, 0x5a, 0x0a, 0x52, 0xba, 0xb1, 0x59, 0x3a, 0x8b, 0xdd, 0x73, 0x3b, 0x80, 0xcd, 0x21,
	0x69, 0xc5, 0x0a, 0xb3, 0xc1, 0x2c, 0x3a, 0xda, 0x3f, 0x99, 0xe4, 0xbd, 0xb5, 0xfc, 0x4c, 0xac,
	0x90, 0x7b, 0x6e, 0xfe, 0x33, 0x02, 0x56, 0x20, 0xbd, 0xeb, 0x2e, 0xdd, 0xd8, 0x09, 0x83, 0xe4,
	0x8a, 0x07, 0x7f, 0x76, 0x97, 0x6a, 0x21, 0x4b, 0x51, 0x55, 0x06, 0xad, 0xed, 0x0c, 0x40, 0x2d,
	0xe4, 0x69, 0x40, 0xdc, 0x42, 0x85, 0x4e, 0x42, 0x70, 0x18, 0x9c, 0x40, 0x80, 0xbc, 0xc7, 0x5e,
	0x71, 0x7a, 0x8d, 0xe2, 0xef, 0x7b, 0x70, 0xbf, 0x40, 0xfa, 0xe0, 0x3a, 0xe1, 0xbe, 0x92, 0x1b,
	0x8b, 0x7e, 0x06, 0xa9, 0x25, 0x41, 0x41, 0xf5, 0xe4, 0x64, 0x9a, 0xbf, 0x16, 0x24, 0x16, 0xae,
	0xe2, 0xfc, 0x54, 0x4a, 0xb4, 0xf6, 0xdc, 0xb1, 0x3c, 0x2c, 0xfd, 0x19, 0x6e, 0xfc, 0x77, 0xb8,
	0x19, 0x0c, 0x5b, 0x5f, 0xbe, 0xcd, 0x12, 0xcf, 0xf5, 0x23, 0x7b, 0x02, 0xb7, 0x2b, 0x41, 0x48,
	0xaa, 0xc6, 0x72, 0x69, 0x74, 0xed, 0xdd, 0xc4, 0xfc, 0x56, 0x0f, 0xbe, 0x31, 0xba, 0xf6, 0x51,
	0xf4, 0x4b, 0xa4, 0x7d, 0x45, 0x31, 0x87, 0x1e, 0x5a, 0xe8, 0x5d, 0xdd, 0xc3, 0x2b, 0x75, 0xf7,
	0xf1, 0x8c, 0xae, 0x89, 0xe7, 0x39, 0x24, 0x6e, 0x62, 0xf7, 0x20, 0x55, 0x4d, 0x85, 0x5b, 0x1f,
	0x43, 0xca, 0xc3, 0xe0, 0x5e, 0xb5, 0xea, 0x6b, 0x08, 0x20, 0xe5, 0xfe, 0x3c, 0xff, 0x16, 0xc1,
	0xa4, 0x40, 0x7a, 0x25, 0xfe, 0x23, 0xc9, 0xa7, 0x70, 0x77, 0xd3, 0xa8, 0xf5, 0x06, 0x4b, 0x55,
	0x61, 0x43, 0x6a, 0xa9, 0xd0, 0x74, 0xdf, 0xc2, 0x41, 0x20, 0xde, 0xee, 0x70, 0x36, 0x85, 0x81,
	0xfe, 0xdc, 0xa0, 0xe9, 0x53, 0xec, 0xa6, 0x9d, 0x9d, 0xe4, 0xdf, 0x76, 0x5e, 0xde, 0x81, 0x21,
	0x6e, 0xf3, 0x95, 0x69, 0xe5, 0x8f, 0xbd, 0x98, 0x2f, 0x8a, 0x8f, 0x03, 0xff, 0xff, 0xbd, 0xf8,
	0x1d, 0x00, 0x00, 0xff, 0xff, 0x58, 0x59, 0x52, 0xeb, 0xc1, 0x03, 0x00, 0x00,
}
