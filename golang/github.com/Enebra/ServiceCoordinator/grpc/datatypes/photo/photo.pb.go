// Code generated by protoc-gen-go.
// source: datatypes/photo.proto
// DO NOT EDIT!

/*
Package photo is a generated protocol buffer package.

It is generated from these files:
	datatypes/photo.proto

It has these top-level messages:
	Photo
	Photos
*/
package photo

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"
import DataTypes2 "github.com/Enebra/ServiceCoordinator/grpc/datatypes/biometrics"
import DataTypes1 "github.com/Enebra/ServiceCoordinator/grpc/datatypes/data"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion2 // please upgrade the proto package

type Purpose int32

const (
	Purpose_NonePurpose Purpose = 0
	Purpose_Thumbnail   Purpose = 1
	Purpose_Population  Purpose = 2
)

var Purpose_name = map[int32]string{
	0: "NonePurpose",
	1: "Thumbnail",
	2: "Population",
}
var Purpose_value = map[string]int32{
	"NonePurpose": 0,
	"Thumbnail":   1,
	"Population":  2,
}

func (x Purpose) String() string {
	return proto.EnumName(Purpose_name, int32(x))
}
func (Purpose) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

type Photo struct {
	Id            *DataTypes1.Key          `protobuf:"bytes,1,opt,name=id" json:"id,omitempty"`
	Url           string                   `protobuf:"bytes,2,opt,name=url" json:"url,omitempty"`
	Width         int32                    `protobuf:"varint,3,opt,name=width" json:"width,omitempty"`
	Height        int32                    `protobuf:"varint,4,opt,name=height" json:"height,omitempty"`
	Purpose       Purpose                  `protobuf:"varint,5,opt,name=purpose,enum=DataTypes.Purpose" json:"purpose,omitempty"`
	BiometricType DataTypes2.BiometricType `protobuf:"varint,6,opt,name=biometric_type,json=biometricType,enum=DataTypes.BiometricType" json:"biometric_type,omitempty"`
	OwnerId       *DataTypes1.Key          `protobuf:"bytes,7,opt,name=owner_id,json=ownerId" json:"owner_id,omitempty"`
}

func (m *Photo) Reset()                    { *m = Photo{} }
func (m *Photo) String() string            { return proto.CompactTextString(m) }
func (*Photo) ProtoMessage()               {}
func (*Photo) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

func (m *Photo) GetId() *DataTypes1.Key {
	if m != nil {
		return m.Id
	}
	return nil
}

func (m *Photo) GetOwnerId() *DataTypes1.Key {
	if m != nil {
		return m.OwnerId
	}
	return nil
}

type Photos struct {
	Photos []*Photo `protobuf:"bytes,1,rep,name=photos" json:"photos,omitempty"`
	Count  int64    `protobuf:"varint,2,opt,name=count" json:"count,omitempty"`
}

func (m *Photos) Reset()                    { *m = Photos{} }
func (m *Photos) String() string            { return proto.CompactTextString(m) }
func (*Photos) ProtoMessage()               {}
func (*Photos) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

func (m *Photos) GetPhotos() []*Photo {
	if m != nil {
		return m.Photos
	}
	return nil
}

func init() {
	proto.RegisterType((*Photo)(nil), "DataTypes.Photo")
	proto.RegisterType((*Photos)(nil), "DataTypes.Photos")
	proto.RegisterEnum("DataTypes.Purpose", Purpose_name, Purpose_value)
}

func init() { proto.RegisterFile("datatypes/photo.proto", fileDescriptor0) }

var fileDescriptor0 = []byte{
	// 371 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0x6c, 0x52, 0xcf, 0x6b, 0xa3, 0x40,
	0x14, 0x5e, 0x75, 0xd5, 0xcd, 0x0b, 0x71, 0x65, 0xc8, 0x2e, 0x43, 0x0e, 0x8b, 0xe4, 0xe4, 0x2e,
	0x8b, 0x42, 0xf6, 0x94, 0xd3, 0x42, 0xda, 0xd2, 0x5f, 0x50, 0xc2, 0x34, 0xa7, 0x5e, 0xc2, 0xa8,
	0x43, 0x1c, 0x48, 0x1c, 0x19, 0xc7, 0xa6, 0x39, 0xf6, 0x5f, 0xe9, 0x5f, 0x5a, 0x46, 0x4d, 0x22,
	0xa5, 0xb7, 0xf7, 0xbd, 0xef, 0x7b, 0xcf, 0xf7, 0x7d, 0x0e, 0xfc, 0xc8, 0xa8, 0xa2, 0xea, 0x50,
	0xb2, 0x2a, 0x2e, 0x73, 0xa1, 0x44, 0x54, 0x4a, 0xa1, 0x04, 0x1a, 0x5c, 0x52, 0x45, 0x57, 0xba,
	0x3d, 0x99, 0x9c, 0x15, 0x09, 0x17, 0x3b, 0xa6, 0x24, 0x4f, 0xab, 0x56, 0x36, 0x19, 0x9f, 0x39,
	0x5d, 0xb5, 0xdd, 0xe9, 0xab, 0x09, 0xf6, 0x52, 0x2f, 0x43, 0xbf, 0xc0, 0xe4, 0x19, 0x36, 0x02,
	0x23, 0x1c, 0xce, 0xbc, 0xe8, 0xb4, 0x33, 0xba, 0x67, 0x07, 0x62, 0xf2, 0x0c, 0xf9, 0x60, 0xd5,
	0x72, 0x8b, 0xcd, 0xc0, 0x08, 0x07, 0x44, 0x97, 0x68, 0x0c, 0xf6, 0x9e, 0x67, 0x2a, 0xc7, 0x56,
	0x60, 0x84, 0x36, 0x69, 0x01, 0xfa, 0x09, 0x4e, 0xce, 0xf8, 0x26, 0x57, 0xf8, 0x6b, 0xd3, 0xee,
	0x10, 0xfa, 0x0b, 0x6e, 0x59, 0xcb, 0x52, 0x54, 0x0c, 0xdb, 0x81, 0x11, 0x7a, 0x33, 0xd4, 0xfb,
	0xc8, 0xb2, 0x65, 0xc8, 0x51, 0x82, 0xfe, 0x83, 0x77, 0x72, 0xb0, 0xd6, 0x57, 0x63, 0xa7, 0x19,
	0xc2, 0xbd, 0xa1, 0xc5, 0x51, 0xa0, 0x21, 0x19, 0x25, 0x7d, 0x88, 0x7e, 0xc3, 0x37, 0xb1, 0x2f,
	0x98, 0x5c, 0xf3, 0x0c, 0xbb, 0x9f, 0x9a, 0x72, 0x1b, 0xfe, 0x36, 0x9b, 0xde, 0x80, 0xd3, 0x44,
	0x50, 0xa1, 0x10, 0x9c, 0x26, 0xd9, 0x0a, 0x1b, 0x81, 0x15, 0x0e, 0x67, 0x7e, 0xff, 0x44, 0x4d,
	0x90, 0x8e, 0xd7, 0xde, 0x53, 0x51, 0x17, 0xaa, 0xc9, 0xc3, 0x22, 0x2d, 0xf8, 0x33, 0x07, 0xb7,
	0x73, 0x82, 0xbe, 0xc3, 0xf0, 0x41, 0x14, 0xac, 0x83, 0xfe, 0x17, 0x34, 0x82, 0xc1, 0x2a, 0xaf,
	0x77, 0x49, 0x41, 0xf9, 0xd6, 0x37, 0x90, 0x07, 0xb0, 0x14, 0x65, 0xbd, 0xa5, 0x8a, 0x8b, 0xc2,
	0x37, 0x17, 0x77, 0xe0, 0xb2, 0x97, 0x68, 0x23, 0xcb, 0xf4, 0x69, 0xbe, 0xe1, 0x2a, 0xaf, 0x93,
	0x28, 0x15, 0xbb, 0xf8, 0xaa, 0x60, 0x89, 0xa4, 0xf1, 0x23, 0x93, 0xcf, 0x3c, 0x65, 0x17, 0x42,
	0xc8, 0x8c, 0x17, 0x54, 0x09, 0x19, 0x6b, 0x69, 0xfc, 0xe1, 0x45, 0xbc, 0x99, 0x16, 0x59, 0x5d,
	0x27, 0x4e, 0xf3, 0x6f, 0xff, 0xbd, 0x07, 0x00, 0x00, 0xff, 0xff, 0xbb, 0xce, 0x66, 0x82, 0x31,
	0x02, 0x00, 0x00,
}
