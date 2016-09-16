// Code generated by protoc-gen-go.
// source: datatypes/location.proto
// DO NOT EDIT!

/*
Package DataTypes is a generated protocol buffer package.

It is generated from these files:
	datatypes/location.proto

It has these top-level messages:
	Location
	Locations
*/
package DataTypes

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"
import DataTypes2 "datatypes"
import DataTypes1 "datatypes"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion2 // please upgrade the proto package

type LocationState int32

const (
	LocationState_Unspecified_State LocationState = 0
	LocationState_Opened            LocationState = 1
	LocationState_Closed            LocationState = 2
	LocationState_Failure           LocationState = 3
)

var LocationState_name = map[int32]string{
	0: "Unspecified_State",
	1: "Opened",
	2: "Closed",
	3: "Failure",
}
var LocationState_value = map[string]int32{
	"Unspecified_State": 0,
	"Opened":            1,
	"Closed":            2,
	"Failure":           3,
}

func (x LocationState) String() string {
	return proto.EnumName(LocationState_name, int32(x))
}
func (LocationState) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

type Location struct {
	Id             *DataTypes1.Key          `protobuf:"bytes,1,opt,name=id" json:"id,omitempty"`
	Name           string                   `protobuf:"bytes,2,opt,name=name" json:"name,omitempty"`
	Description    string                   `protobuf:"bytes,3,opt,name=description" json:"description,omitempty"`
	UnitMacAddress string                   `protobuf:"bytes,4,opt,name=unit_mac_address,json=unitMacAddress" json:"unit_mac_address,omitempty"`
	AccessDevice   *DataTypes2.AccessDevice `protobuf:"bytes,5,opt,name=access_device,json=accessDevice" json:"access_device,omitempty"`
}

func (m *Location) Reset()                    { *m = Location{} }
func (m *Location) String() string            { return proto.CompactTextString(m) }
func (*Location) ProtoMessage()               {}
func (*Location) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

func (m *Location) GetId() *DataTypes1.Key {
	if m != nil {
		return m.Id
	}
	return nil
}

func (m *Location) GetAccessDevice() *DataTypes2.AccessDevice {
	if m != nil {
		return m.AccessDevice
	}
	return nil
}

type Locations struct {
	Items []*Location `protobuf:"bytes,1,rep,name=items" json:"items,omitempty"`
	Count int64       `protobuf:"varint,2,opt,name=count" json:"count,omitempty"`
}

func (m *Locations) Reset()                    { *m = Locations{} }
func (m *Locations) String() string            { return proto.CompactTextString(m) }
func (*Locations) ProtoMessage()               {}
func (*Locations) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

func (m *Locations) GetItems() []*Location {
	if m != nil {
		return m.Items
	}
	return nil
}

func init() {
	proto.RegisterType((*Location)(nil), "DataTypes.Location")
	proto.RegisterType((*Locations)(nil), "DataTypes.Locations")
	proto.RegisterEnum("DataTypes.LocationState", LocationState_name, LocationState_value)
}

func init() { proto.RegisterFile("datatypes/location.proto", fileDescriptor0) }

var fileDescriptor0 = []byte{
	// 321 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0x4c, 0x90, 0x4f, 0x4f, 0xc2, 0x40,
	0x10, 0xc5, 0x6d, 0xcb, 0x1f, 0x99, 0x0a, 0xd6, 0x15, 0xc3, 0x86, 0x83, 0x69, 0x38, 0x55, 0x0f,
	0x35, 0xc1, 0xab, 0x17, 0x94, 0xe8, 0x01, 0x8c, 0x49, 0xc5, 0x73, 0x33, 0xee, 0x8e, 0x66, 0x13,
	0x68, 0x9b, 0xee, 0x62, 0xe4, 0xeb, 0xf8, 0x69, 0xfc, 0x58, 0xa6, 0x5b, 0xd1, 0xde, 0x66, 0xde,
	0xfb, 0xe5, 0xe5, 0xcd, 0x00, 0x97, 0x68, 0xd0, 0xec, 0x0a, 0xd2, 0x57, 0xeb, 0x5c, 0xa0, 0x51,
	0x79, 0x16, 0x17, 0x65, 0x6e, 0x72, 0xd6, 0x9b, 0xa3, 0xc1, 0x55, 0xe5, 0x8c, 0x47, 0xff, 0x90,
	0xa4, 0x0f, 0x25, 0x48, 0xd7, 0xcc, 0x78, 0xd8, 0x30, 0xd0, 0x60, 0xad, 0x4e, 0xbe, 0x1d, 0x38,
	0x5c, 0xfe, 0x86, 0xb1, 0x73, 0x70, 0x95, 0xe4, 0x4e, 0xe8, 0x44, 0xfe, 0x74, 0x10, 0xff, 0x65,
	0xc6, 0x0b, 0xda, 0x25, 0xae, 0x92, 0x8c, 0x41, 0x2b, 0xc3, 0x0d, 0x71, 0x37, 0x74, 0xa2, 0x5e,
	0x62, 0x67, 0x16, 0x82, 0x2f, 0x49, 0x8b, 0x52, 0x15, 0x55, 0x04, 0xf7, 0xac, 0xd5, 0x94, 0x58,
	0x04, 0xc1, 0x36, 0x53, 0x26, 0xdd, 0xa0, 0x48, 0x51, 0xca, 0x92, 0xb4, 0xe6, 0x2d, 0x8b, 0x0d,
	0x2a, 0xfd, 0x11, 0xc5, 0xac, 0x56, 0xd9, 0x0d, 0xf4, 0x51, 0x08, 0xd2, 0x3a, 0xad, 0xab, 0xf3,
	0xb6, 0xad, 0x32, 0x6a, 0x54, 0x99, 0x59, 0x7f, 0x6e, 0xed, 0xe4, 0x08, 0x1b, 0xdb, 0x64, 0x09,
	0xbd, 0xfd, 0x25, 0x9a, 0x5d, 0x40, 0x5b, 0x19, 0xda, 0x68, 0xee, 0x84, 0x5e, 0xe4, 0x4f, 0x4f,
	0x1b, 0x11, 0x7b, 0x28, 0xa9, 0x09, 0x36, 0x84, 0xb6, 0xc8, 0xb7, 0x99, 0xb1, 0x67, 0x79, 0x49,
	0xbd, 0x5c, 0x2e, 0xa0, 0xbf, 0x07, 0x9f, 0x0d, 0x1a, 0x62, 0x67, 0x70, 0xf2, 0x92, 0xe9, 0x82,
	0x84, 0x7a, 0x53, 0x24, 0x53, 0x2b, 0x06, 0x07, 0x0c, 0xa0, 0xf3, 0x54, 0x50, 0x46, 0x32, 0x70,
	0xaa, 0xf9, 0x6e, 0x9d, 0x6b, 0x92, 0x81, 0xcb, 0x7c, 0xe8, 0xde, 0xa3, 0x5a, 0x6f, 0x4b, 0x0a,
	0xbc, 0xdb, 0x63, 0xe8, 0xd2, 0x67, 0xfc, 0x5e, 0x16, 0xe2, 0xcb, 0xf5, 0x92, 0xd5, 0xc3, 0x6b,
	0xc7, 0x7e, 0xff, 0xfa, 0x27, 0x00, 0x00, 0xff, 0xff, 0x93, 0x6b, 0xc0, 0x68, 0xd3, 0x01, 0x00,
	0x00,
}
