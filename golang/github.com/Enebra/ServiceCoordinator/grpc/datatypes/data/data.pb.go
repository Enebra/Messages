// Code generated by protoc-gen-go.
// source: datatypes/data.proto
// DO NOT EDIT!

/*
Package data is a generated protocol buffer package.

It is generated from these files:
	datatypes/data.proto

It has these top-level messages:
	MessageBytes
	Key
*/
package data

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

type DataType int32

const (
	DataType_NoneType           DataType = 0
	DataType_GetRequestType     DataType = 1
	DataType_GetResponseType    DataType = 2
	DataType_CommitRequestType  DataType = 3
	DataType_CommitResponseType DataType = 4
)

var DataType_name = map[int32]string{
	0: "NoneType",
	1: "GetRequestType",
	2: "GetResponseType",
	3: "CommitRequestType",
	4: "CommitResponseType",
}
var DataType_value = map[string]int32{
	"NoneType":           0,
	"GetRequestType":     1,
	"GetResponseType":    2,
	"CommitRequestType":  3,
	"CommitResponseType": 4,
}

func (x DataType) String() string {
	return proto.EnumName(DataType_name, int32(x))
}
func (DataType) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

type MessageBytes struct {
	Data []byte   `protobuf:"bytes,1,opt,name=data,proto3" json:"data,omitempty"`
	Type DataType `protobuf:"varint,2,opt,name=type,enum=DataTypes.DataType" json:"type,omitempty"`
}

func (m *MessageBytes) Reset()                    { *m = MessageBytes{} }
func (m *MessageBytes) String() string            { return proto.CompactTextString(m) }
func (*MessageBytes) ProtoMessage()               {}
func (*MessageBytes) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

type Key struct {
	// Types that are valid to be assigned to IdType:
	//	*Key_Id
	//	*Key_Guid
	IdType isKey_IdType `protobuf_oneof:"id_type"`
}

func (m *Key) Reset()                    { *m = Key{} }
func (m *Key) String() string            { return proto.CompactTextString(m) }
func (*Key) ProtoMessage()               {}
func (*Key) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

type isKey_IdType interface {
	isKey_IdType()
}

type Key_Id struct {
	Id int64 `protobuf:"varint,1,opt,name=id,oneof"`
}
type Key_Guid struct {
	Guid string `protobuf:"bytes,2,opt,name=guid,oneof"`
}

func (*Key_Id) isKey_IdType()   {}
func (*Key_Guid) isKey_IdType() {}

func (m *Key) GetIdType() isKey_IdType {
	if m != nil {
		return m.IdType
	}
	return nil
}

func (m *Key) GetId() int64 {
	if x, ok := m.GetIdType().(*Key_Id); ok {
		return x.Id
	}
	return 0
}

func (m *Key) GetGuid() string {
	if x, ok := m.GetIdType().(*Key_Guid); ok {
		return x.Guid
	}
	return ""
}

// XXX_OneofFuncs is for the internal use of the proto package.
func (*Key) XXX_OneofFuncs() (func(msg proto.Message, b *proto.Buffer) error, func(msg proto.Message, tag, wire int, b *proto.Buffer) (bool, error), func(msg proto.Message) (n int), []interface{}) {
	return _Key_OneofMarshaler, _Key_OneofUnmarshaler, _Key_OneofSizer, []interface{}{
		(*Key_Id)(nil),
		(*Key_Guid)(nil),
	}
}

func _Key_OneofMarshaler(msg proto.Message, b *proto.Buffer) error {
	m := msg.(*Key)
	// id_type
	switch x := m.IdType.(type) {
	case *Key_Id:
		b.EncodeVarint(1<<3 | proto.WireVarint)
		b.EncodeVarint(uint64(x.Id))
	case *Key_Guid:
		b.EncodeVarint(2<<3 | proto.WireBytes)
		b.EncodeStringBytes(x.Guid)
	case nil:
	default:
		return fmt.Errorf("Key.IdType has unexpected type %T", x)
	}
	return nil
}

func _Key_OneofUnmarshaler(msg proto.Message, tag, wire int, b *proto.Buffer) (bool, error) {
	m := msg.(*Key)
	switch tag {
	case 1: // id_type.id
		if wire != proto.WireVarint {
			return true, proto.ErrInternalBadWireType
		}
		x, err := b.DecodeVarint()
		m.IdType = &Key_Id{int64(x)}
		return true, err
	case 2: // id_type.guid
		if wire != proto.WireBytes {
			return true, proto.ErrInternalBadWireType
		}
		x, err := b.DecodeStringBytes()
		m.IdType = &Key_Guid{x}
		return true, err
	default:
		return false, nil
	}
}

func _Key_OneofSizer(msg proto.Message) (n int) {
	m := msg.(*Key)
	// id_type
	switch x := m.IdType.(type) {
	case *Key_Id:
		n += proto.SizeVarint(1<<3 | proto.WireVarint)
		n += proto.SizeVarint(uint64(x.Id))
	case *Key_Guid:
		n += proto.SizeVarint(2<<3 | proto.WireBytes)
		n += proto.SizeVarint(uint64(len(x.Guid)))
		n += len(x.Guid)
	case nil:
	default:
		panic(fmt.Sprintf("proto: unexpected type %T in oneof", x))
	}
	return n
}

func init() {
	proto.RegisterType((*MessageBytes)(nil), "DataTypes.MessageBytes")
	proto.RegisterType((*Key)(nil), "DataTypes.Key")
	proto.RegisterEnum("DataTypes.DataType", DataType_name, DataType_value)
}

func init() { proto.RegisterFile("datatypes/data.proto", fileDescriptor0) }

var fileDescriptor0 = []byte{
	// 275 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0x54, 0x90, 0x4d, 0x4f, 0xf2, 0x40,
	0x14, 0x85, 0xe9, 0x47, 0x5e, 0xe0, 0x86, 0xf0, 0xe2, 0x05, 0x0d, 0x4b, 0xc2, 0x46, 0xe2, 0xa2,
	0x4d, 0x74, 0xc3, 0xba, 0x68, 0xc0, 0x10, 0x5d, 0x8c, 0xac, 0xdc, 0x98, 0x69, 0xe7, 0xa6, 0xce,
	0xa2, 0x9d, 0x3a, 0x33, 0x35, 0xf6, 0xef, 0xf8, 0x4b, 0xcd, 0x8c, 0x81, 0xc8, 0xee, 0xdc, 0x93,
	0xe7, 0x3e, 0x8b, 0x03, 0x33, 0xc1, 0x2d, 0xb7, 0x5d, 0x43, 0x26, 0x75, 0x29, 0x69, 0xb4, 0xb2,
	0x0a, 0x87, 0xf7, 0xdc, 0xf2, 0x83, 0x6b, 0x97, 0x7b, 0x18, 0x3d, 0x91, 0x31, 0xbc, 0xa4, 0xac,
	0xb3, 0x64, 0x10, 0x21, 0x76, 0xe0, 0x3c, 0x58, 0x04, 0xab, 0x11, 0xf3, 0x19, 0xaf, 0x21, 0x76,
	0x8a, 0x79, 0xb8, 0x08, 0x56, 0xe3, 0xdb, 0x69, 0x72, 0xfa, 0x3e, 0x25, 0xe6, 0x81, 0xe5, 0x1a,
	0xa2, 0x3d, 0x75, 0x38, 0x81, 0x50, 0x0a, 0x6f, 0x88, 0x76, 0x3d, 0x16, 0x4a, 0x81, 0x33, 0x88,
	0xcb, 0x56, 0x0a, 0x6f, 0x18, 0xee, 0x7a, 0xcc, 0x5f, 0xd9, 0x10, 0xfa, 0x52, 0xbc, 0xb9, 0xcf,
	0x9b, 0x06, 0x06, 0x47, 0x17, 0x8e, 0x60, 0xf0, 0xac, 0x6a, 0x72, 0x79, 0xd2, 0x43, 0x84, 0xf1,
	0x96, 0x2c, 0xa3, 0x8f, 0x96, 0x8c, 0xf5, 0x5d, 0x80, 0x53, 0xf8, 0xef, 0x3b, 0xd3, 0xa8, 0xda,
	0xfc, 0x82, 0x21, 0x5e, 0xc2, 0xc5, 0x46, 0x55, 0x95, 0x3c, 0x63, 0x23, 0xbc, 0x02, 0x3c, 0xd6,
	0x7f, 0xf0, 0x38, 0x7b, 0x84, 0x3e, 0x7d, 0x25, 0xa5, 0x6e, 0x8a, 0xd7, 0x75, 0x29, 0xed, 0x7b,
	0x9b, 0x27, 0x85, 0xaa, 0xd2, 0x87, 0x9a, 0x72, 0xcd, 0xd3, 0x17, 0xd2, 0x9f, 0xb2, 0xa0, 0x8d,
	0x52, 0x5a, 0xc8, 0x9a, 0x5b, 0xa5, 0x53, 0x87, 0xa6, 0xe7, 0x73, 0x7e, 0x87, 0x11, 0x3b, 0x6c,
	0xf3, 0x7f, 0x7e, 0xd5, 0xbb, 0x9f, 0x00, 0x00, 0x00, 0xff, 0xff, 0x86, 0x87, 0x17, 0xa8, 0x6d,
	0x01, 0x00, 0x00,
}
