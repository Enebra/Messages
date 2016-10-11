// Code generated by protoc-gen-go.
// source: datatypes/geometry.proto
// DO NOT EDIT!

/*
Package geometry is a generated protocol buffer package.

It is generated from these files:
	datatypes/geometry.proto

It has these top-level messages:
	Position
	Box
*/
package geometry

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion2 // please upgrade the proto package

type Position struct {
	X int32 `protobuf:"varint,1,opt,name=x" json:"x,omitempty"`
	Y int32 `protobuf:"varint,2,opt,name=y" json:"y,omitempty"`
}

func (m *Position) Reset()                    { *m = Position{} }
func (m *Position) String() string            { return proto.CompactTextString(m) }
func (*Position) ProtoMessage()               {}
func (*Position) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

type Box struct {
	Begin  *Position `protobuf:"bytes,1,opt,name=begin" json:"begin,omitempty"`
	Width  int32     `protobuf:"varint,2,opt,name=width" json:"width,omitempty"`
	Height int32     `protobuf:"varint,3,opt,name=height" json:"height,omitempty"`
}

func (m *Box) Reset()                    { *m = Box{} }
func (m *Box) String() string            { return proto.CompactTextString(m) }
func (*Box) ProtoMessage()               {}
func (*Box) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

func (m *Box) GetBegin() *Position {
	if m != nil {
		return m.Begin
	}
	return nil
}

func init() {
	proto.RegisterType((*Position)(nil), "DataTypes.Position")
	proto.RegisterType((*Box)(nil), "DataTypes.Box")
}

func init() { proto.RegisterFile("datatypes/geometry.proto", fileDescriptor0) }

var fileDescriptor0 = []byte{
	// 215 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0x64, 0x8f, 0x31, 0x4b, 0xc4, 0x40,
	0x10, 0x46, 0xc9, 0x85, 0x9c, 0x3a, 0x5a, 0xad, 0x22, 0x29, 0xe5, 0x0a, 0xd1, 0x66, 0x17, 0xb4,
	0xb5, 0x3a, 0x15, 0x2b, 0x41, 0xe2, 0x55, 0x16, 0xc2, 0x26, 0x19, 0x76, 0xa7, 0xb8, 0x9d, 0xb0,
	0x37, 0xea, 0xee, 0xdf, 0xf1, 0x97, 0x4a, 0x92, 0xd3, 0xc6, 0xf2, 0xcd, 0x3c, 0x1e, 0x7c, 0x50,
	0xf7, 0x56, 0xac, 0xe4, 0x01, 0x77, 0xc6, 0x21, 0x6f, 0x51, 0x62, 0xd6, 0x43, 0x64, 0x61, 0x75,
	0xf4, 0x60, 0xc5, 0x6e, 0xc6, 0xcf, 0xea, 0x12, 0x0e, 0x5f, 0x78, 0x47, 0x42, 0x1c, 0xd4, 0x09,
	0x14, 0xa9, 0x2e, 0x2e, 0x8a, 0xab, 0xaa, 0x29, 0xd2, 0x48, 0xb9, 0x5e, 0xcc, 0x94, 0x57, 0xef,
	0x50, 0xae, 0x39, 0xa9, 0x6b, 0xa8, 0x5a, 0x74, 0x14, 0x26, 0xed, 0xf8, 0xe6, 0x54, 0xff, 0x95,
	0xf4, 0x6f, 0xa6, 0x99, 0x0d, 0x75, 0x06, 0xd5, 0x17, 0xf5, 0xe2, 0xf7, 0x8d, 0x19, 0xd4, 0x39,
	0x2c, 0x3d, 0x92, 0xf3, 0x52, 0x97, 0xd3, 0x79, 0x4f, 0xeb, 0x67, 0x38, 0xc0, 0xa4, 0x5d, 0x1c,
	0xba, 0xb7, 0x3b, 0x47, 0xe2, 0x3f, 0x5a, 0xdd, 0xf1, 0xd6, 0x3c, 0x06, 0x6c, 0xa3, 0x35, 0xaf,
	0x18, 0x3f, 0xa9, 0xc3, 0x7b, 0xe6, 0xd8, 0x53, 0xb0, 0xc2, 0xd1, 0x8c, 0xaa, 0xf9, 0xbf, 0xf0,
	0x7b, 0x51, 0x36, 0x9b, 0xa7, 0x76, 0x39, 0x0d, 0xbd, 0xfd, 0x09, 0x00, 0x00, 0xff, 0xff, 0x1c,
	0x74, 0x11, 0xa3, 0x04, 0x01, 0x00, 0x00,
}