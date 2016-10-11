// Code generated by protoc-gen-go.
// source: datatypes/biometrics.proto
// DO NOT EDIT!

/*
Package biometrics is a generated protocol buffer package.

It is generated from these files:
	datatypes/biometrics.proto

It has these top-level messages:
	Faces
	FaceCharacteristic
	Match
	Matches
*/
package biometrics

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"
import DataTypes "github.com/Enebra/ServiceCoordinator/grpc/datatypes/geometry"
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

type BiometricType int32

const (
	BiometricType_UnspecifiedBio BiometricType = 0
	BiometricType_Facial         BiometricType = 1
	BiometricType_Fingerprint    BiometricType = 2
	BiometricType_Iris           BiometricType = 3
	BiometricType_All            BiometricType = 4
)

var BiometricType_name = map[int32]string{
	0: "UnspecifiedBio",
	1: "Facial",
	2: "Fingerprint",
	3: "Iris",
	4: "All",
}
var BiometricType_value = map[string]int32{
	"UnspecifiedBio": 0,
	"Facial":         1,
	"Fingerprint":    2,
	"Iris":           3,
	"All":            4,
}

func (x BiometricType) String() string {
	return proto.EnumName(BiometricType_name, int32(x))
}
func (BiometricType) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

type EyeType int32

const (
	EyeType_Unspecified_Eye EyeType = 0
	EyeType_Left            EyeType = 1
	EyeType_Right           EyeType = 2
	EyeType_Both            EyeType = 3
)

var EyeType_name = map[int32]string{
	0: "Unspecified_Eye",
	1: "Left",
	2: "Right",
	3: "Both",
}
var EyeType_value = map[string]int32{
	"Unspecified_Eye": 0,
	"Left":            1,
	"Right":           2,
	"Both":            3,
}

func (x EyeType) String() string {
	return proto.EnumName(EyeType_name, int32(x))
}
func (EyeType) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

type Finger int32

const (
	Finger_Unspecified_Finger Finger = 0
	Finger_RightThumb         Finger = 1
	Finger_LeftThumb          Finger = 2
	Finger_RightIndex         Finger = 3
	Finger_LeftIndex          Finger = 4
	Finger_RightMiddle        Finger = 5
	Finger_LeftMiddle         Finger = 6
	Finger_RightRing          Finger = 7
	Finger_LeftRing           Finger = 8
	Finger_RightLittle        Finger = 9
	Finger_LeftLittle         Finger = 10
)

var Finger_name = map[int32]string{
	0:  "Unspecified_Finger",
	1:  "RightThumb",
	2:  "LeftThumb",
	3:  "RightIndex",
	4:  "LeftIndex",
	5:  "RightMiddle",
	6:  "LeftMiddle",
	7:  "RightRing",
	8:  "LeftRing",
	9:  "RightLittle",
	10: "LeftLittle",
}
var Finger_value = map[string]int32{
	"Unspecified_Finger": 0,
	"RightThumb":         1,
	"LeftThumb":          2,
	"RightIndex":         3,
	"LeftIndex":          4,
	"RightMiddle":        5,
	"LeftMiddle":         6,
	"RightRing":          7,
	"LeftRing":           8,
	"RightLittle":        9,
	"LeftLittle":         10,
}

func (x Finger) String() string {
	return proto.EnumName(Finger_name, int32(x))
}
func (Finger) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{2} }

type FacialIsoComplianceTemplate int32

const (
	FacialIsoComplianceTemplate_Unspecified_IsoTemplate         FacialIsoComplianceTemplate = 0
	FacialIsoComplianceTemplate_OnlyOneFaceVisible              FacialIsoComplianceTemplate = 1
	FacialIsoComplianceTemplate_goodVerticalFacePosition        FacialIsoComplianceTemplate = 2
	FacialIsoComplianceTemplate_horizontallyCenteredFace        FacialIsoComplianceTemplate = 3
	FacialIsoComplianceTemplate_widthOfHead                     FacialIsoComplianceTemplate = 4
	FacialIsoComplianceTemplate_lengthOfHead                    FacialIsoComplianceTemplate = 5
	FacialIsoComplianceTemplate_widthOfHeadBestPractice         FacialIsoComplianceTemplate = 6
	FacialIsoComplianceTemplate_lengthOfHeadBestPractice        FacialIsoComplianceTemplate = 7
	FacialIsoComplianceTemplate_resolution                      FacialIsoComplianceTemplate = 8
	FacialIsoComplianceTemplate_resolutionBestPractice          FacialIsoComplianceTemplate = 9
	FacialIsoComplianceTemplate_imageWidthToHeightBestPractice  FacialIsoComplianceTemplate = 10
	FacialIsoComplianceTemplate_goodExposure                    FacialIsoComplianceTemplate = 11
	FacialIsoComplianceTemplate_goodGrayScaleProfile            FacialIsoComplianceTemplate = 12
	FacialIsoComplianceTemplate_hasNaturalSkinColour            FacialIsoComplianceTemplate = 13
	FacialIsoComplianceTemplate_noHotSpots                      FacialIsoComplianceTemplate = 14
	FacialIsoComplianceTemplate_isBackgroundUniformBestPractice FacialIsoComplianceTemplate = 15
	FacialIsoComplianceTemplate_isFrontal                       FacialIsoComplianceTemplate = 16
	FacialIsoComplianceTemplate_isFrontalBestPractice           FacialIsoComplianceTemplate = 17
	FacialIsoComplianceTemplate_isLightingUniform               FacialIsoComplianceTemplate = 18
	FacialIsoComplianceTemplate_eyesOpenBestPractice            FacialIsoComplianceTemplate = 19
	FacialIsoComplianceTemplate_eyesGazeFrontalBestPractice     FacialIsoComplianceTemplate = 20
	FacialIsoComplianceTemplate_eyesNotRedBestPractice          FacialIsoComplianceTemplate = 21
	FacialIsoComplianceTemplate_noTintedGlasses                 FacialIsoComplianceTemplate = 22
	FacialIsoComplianceTemplate_isSharp                         FacialIsoComplianceTemplate = 23
	FacialIsoComplianceTemplate_mouthClosedBestPractice         FacialIsoComplianceTemplate = 24
)

var FacialIsoComplianceTemplate_name = map[int32]string{
	0:  "Unspecified_IsoTemplate",
	1:  "OnlyOneFaceVisible",
	2:  "goodVerticalFacePosition",
	3:  "horizontallyCenteredFace",
	4:  "widthOfHead",
	5:  "lengthOfHead",
	6:  "widthOfHeadBestPractice",
	7:  "lengthOfHeadBestPractice",
	8:  "resolution",
	9:  "resolutionBestPractice",
	10: "imageWidthToHeightBestPractice",
	11: "goodExposure",
	12: "goodGrayScaleProfile",
	13: "hasNaturalSkinColour",
	14: "noHotSpots",
	15: "isBackgroundUniformBestPractice",
	16: "isFrontal",
	17: "isFrontalBestPractice",
	18: "isLightingUniform",
	19: "eyesOpenBestPractice",
	20: "eyesGazeFrontalBestPractice",
	21: "eyesNotRedBestPractice",
	22: "noTintedGlasses",
	23: "isSharp",
	24: "mouthClosedBestPractice",
}
var FacialIsoComplianceTemplate_value = map[string]int32{
	"Unspecified_IsoTemplate":         0,
	"OnlyOneFaceVisible":              1,
	"goodVerticalFacePosition":        2,
	"horizontallyCenteredFace":        3,
	"widthOfHead":                     4,
	"lengthOfHead":                    5,
	"widthOfHeadBestPractice":         6,
	"lengthOfHeadBestPractice":        7,
	"resolution":                      8,
	"resolutionBestPractice":          9,
	"imageWidthToHeightBestPractice":  10,
	"goodExposure":                    11,
	"goodGrayScaleProfile":            12,
	"hasNaturalSkinColour":            13,
	"noHotSpots":                      14,
	"isBackgroundUniformBestPractice": 15,
	"isFrontal":                       16,
	"isFrontalBestPractice":           17,
	"isLightingUniform":               18,
	"eyesOpenBestPractice":            19,
	"eyesGazeFrontalBestPractice":     20,
	"eyesNotRedBestPractice":          21,
	"noTintedGlasses":                 22,
	"isSharp":                         23,
	"mouthClosedBestPractice":         24,
}

func (x FacialIsoComplianceTemplate) String() string {
	return proto.EnumName(FacialIsoComplianceTemplate_name, int32(x))
}
func (FacialIsoComplianceTemplate) EnumDescriptor() ([]byte, []int) { return fileDescriptor0, []int{3} }

type Faces struct {
	Faces []*FaceCharacteristic `protobuf:"bytes,1,rep,name=Faces,json=faces" json:"Faces,omitempty"`
}

func (m *Faces) Reset()                    { *m = Faces{} }
func (m *Faces) String() string            { return proto.CompactTextString(m) }
func (*Faces) ProtoMessage()               {}
func (*Faces) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{0} }

func (m *Faces) GetFaces() []*FaceCharacteristic {
	if m != nil {
		return m.Faces
	}
	return nil
}

type FaceCharacteristic struct {
	Id         *DataTypes1.Key `protobuf:"bytes,1,opt,name=id" json:"id,omitempty"`
	Box        *DataTypes.Box  `protobuf:"bytes,2,opt,name=box" json:"box,omitempty"`
	Confidence float32         `protobuf:"fixed32,3,opt,name=confidence" json:"confidence,omitempty"`
	PersonId   int64           `protobuf:"varint,4,opt,name=person_id,json=personId" json:"person_id,omitempty"`
	PhotoId    int64           `protobuf:"varint,5,opt,name=photo_id,json=photoId" json:"photo_id,omitempty"`
}

func (m *FaceCharacteristic) Reset()                    { *m = FaceCharacteristic{} }
func (m *FaceCharacteristic) String() string            { return proto.CompactTextString(m) }
func (*FaceCharacteristic) ProtoMessage()               {}
func (*FaceCharacteristic) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{1} }

func (m *FaceCharacteristic) GetId() *DataTypes1.Key {
	if m != nil {
		return m.Id
	}
	return nil
}

func (m *FaceCharacteristic) GetBox() *DataTypes.Box {
	if m != nil {
		return m.Box
	}
	return nil
}

type Match struct {
	FaceId *DataTypes1.Key `protobuf:"bytes,2,opt,name=face_id,json=faceId" json:"face_id,omitempty"`
	Match  float32         `protobuf:"fixed32,3,opt,name=match" json:"match,omitempty"`
}

func (m *Match) Reset()                    { *m = Match{} }
func (m *Match) String() string            { return proto.CompactTextString(m) }
func (*Match) ProtoMessage()               {}
func (*Match) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{2} }

func (m *Match) GetFaceId() *DataTypes1.Key {
	if m != nil {
		return m.FaceId
	}
	return nil
}

type Matches struct {
	FaceId  *DataTypes1.Key `protobuf:"bytes,1,opt,name=face_id,json=faceId" json:"face_id,omitempty"`
	Matches []*Match        `protobuf:"bytes,2,rep,name=matches" json:"matches,omitempty"`
}

func (m *Matches) Reset()                    { *m = Matches{} }
func (m *Matches) String() string            { return proto.CompactTextString(m) }
func (*Matches) ProtoMessage()               {}
func (*Matches) Descriptor() ([]byte, []int) { return fileDescriptor0, []int{3} }

func (m *Matches) GetFaceId() *DataTypes1.Key {
	if m != nil {
		return m.FaceId
	}
	return nil
}

func (m *Matches) GetMatches() []*Match {
	if m != nil {
		return m.Matches
	}
	return nil
}

func init() {
	proto.RegisterType((*Faces)(nil), "DataTypes.Faces")
	proto.RegisterType((*FaceCharacteristic)(nil), "DataTypes.FaceCharacteristic")
	proto.RegisterType((*Match)(nil), "DataTypes.Match")
	proto.RegisterType((*Matches)(nil), "DataTypes.Matches")
	proto.RegisterEnum("DataTypes.BiometricType", BiometricType_name, BiometricType_value)
	proto.RegisterEnum("DataTypes.EyeType", EyeType_name, EyeType_value)
	proto.RegisterEnum("DataTypes.Finger", Finger_name, Finger_value)
	proto.RegisterEnum("DataTypes.FacialIsoComplianceTemplate", FacialIsoComplianceTemplate_name, FacialIsoComplianceTemplate_value)
}

func init() { proto.RegisterFile("datatypes/biometrics.proto", fileDescriptor0) }

var fileDescriptor0 = []byte{
	// 882 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0x7c, 0x95, 0xdd, 0x6e, 0xdb, 0x46,
	0x13, 0x86, 0x4d, 0xc9, 0xb2, 0xa4, 0xf1, 0xdf, 0x66, 0x63, 0x3b, 0x8c, 0x9d, 0xcf, 0x31, 0xfc,
	0x1d, 0xd4, 0xf0, 0x81, 0x0d, 0x24, 0xa7, 0x6d, 0x81, 0x4a, 0xf5, 0x8f, 0x50, 0x27, 0x36, 0x24,
	0x25, 0x05, 0x7a, 0xd0, 0x60, 0x45, 0x8e, 0xc8, 0x41, 0x56, 0xbb, 0xc4, 0xee, 0xaa, 0xb5, 0x72,
	0x11, 0xbd, 0x88, 0x5e, 0x40, 0xef, 0xa0, 0xf7, 0x56, 0x0c, 0x25, 0xcb, 0x52, 0x63, 0xf4, 0x8c,
	0x33, 0xef, 0x33, 0xef, 0xce, 0xcc, 0x92, 0x12, 0xec, 0xa7, 0x2a, 0xa8, 0x30, 0x29, 0xd0, 0x9f,
	0x0f, 0xc8, 0x8e, 0x30, 0x38, 0x4a, 0xfc, 0x59, 0xe1, 0x6c, 0xb0, 0xb2, 0xf9, 0xa3, 0x0a, 0xaa,
	0xcf, 0xda, 0x7e, 0xfc, 0x88, 0x65, 0x58, 0x62, 0x93, 0x29, 0xb4, 0xbf, 0xf3, 0xa8, 0xf0, 0xd3,
	0x34, 0x7b, 0xfc, 0x2d, 0xd4, 0x2e, 0x55, 0x82, 0x5e, 0xbe, 0x9d, 0x3d, 0xc4, 0xd1, 0x51, 0xf5,
	0x64, 0xfd, 0xcd, 0xff, 0xce, 0xe6, 0x9e, 0x67, 0x9c, 0x6f, 0xe7, 0xca, 0xa9, 0x24, 0xa0, 0x23,
	0x1f, 0x28, 0xe9, 0xd6, 0x86, 0xcc, 0x1e, 0xff, 0x15, 0x81, 0xfc, 0x5a, 0x95, 0x87, 0x50, 0xa1,
	0x34, 0x8e, 0x8e, 0xa2, 0x93, 0xf5, 0x37, 0x5b, 0x0b, 0x46, 0x3f, 0xe1, 0xa4, 0x5b, 0xa1, 0x54,
	0x1e, 0x41, 0x75, 0x60, 0xef, 0xe3, 0xca, 0x57, 0x40, 0xcb, 0xde, 0x77, 0x59, 0x92, 0x87, 0x00,
	0x89, 0x35, 0x43, 0x4a, 0xd1, 0x24, 0x18, 0x57, 0x8f, 0xa2, 0x93, 0x4a, 0x77, 0x21, 0x23, 0x0f,
	0xa0, 0x59, 0xa0, 0xf3, 0xd6, 0x7c, 0xa2, 0x34, 0x5e, 0x3d, 0x8a, 0x4e, 0xaa, 0xdd, 0xc6, 0x34,
	0xd1, 0x49, 0xe5, 0x4b, 0x68, 0x14, 0xb9, 0x0d, 0x96, 0xb5, 0x5a, 0xa9, 0xd5, 0xcb, 0xb8, 0x93,
	0x1e, 0x5f, 0x42, 0xed, 0x9d, 0x0a, 0x49, 0x2e, 0xbf, 0x81, 0x3a, 0x8f, 0xc0, 0x48, 0xe5, 0xc9,
	0x3e, 0xd7, 0x58, 0xee, 0xa4, 0x72, 0x07, 0x6a, 0x23, 0xae, 0x98, 0x35, 0x31, 0x0d, 0x8e, 0x7f,
	0x85, 0x7a, 0xe9, 0x83, 0x7e, 0xd1, 0x29, 0xfa, 0x4f, 0xa7, 0x53, 0xa8, 0x8f, 0xa6, 0x35, 0x71,
	0xa5, 0xdc, 0xb1, 0x58, 0x00, 0x4b, 0xb7, 0xee, 0x03, 0x70, 0xda, 0x83, 0xcd, 0xd6, 0xc3, 0x2d,
	0x33, 0x20, 0x25, 0x6c, 0x7d, 0x30, 0xbe, 0xc0, 0x84, 0x86, 0x84, 0x69, 0x8b, 0xac, 0x58, 0x91,
	0x00, 0x6b, 0x97, 0x2a, 0x21, 0xa5, 0x45, 0x24, 0xb7, 0x61, 0xfd, 0x92, 0x4c, 0x86, 0xae, 0x70,
	0x64, 0x82, 0xa8, 0xc8, 0x06, 0xac, 0x76, 0x1c, 0x79, 0x51, 0x95, 0x75, 0xa8, 0xfe, 0xa0, 0xb5,
	0x58, 0x3d, 0xfd, 0x0e, 0xea, 0x17, 0x13, 0x2c, 0xed, 0x9e, 0xc3, 0xf6, 0x82, 0xdd, 0xa7, 0x8b,
	0x09, 0x8a, 0x15, 0x2e, 0xb9, 0xc1, 0x61, 0x10, 0x91, 0x6c, 0x42, 0xad, 0x4b, 0x59, 0x3e, 0xf3,
	0x69, 0xd9, 0x90, 0x8b, 0xea, 0xe9, 0xdf, 0x11, 0xac, 0x4d, 0xcf, 0x90, 0x7b, 0x20, 0x17, 0xcb,
	0xa7, 0x59, 0xb1, 0x22, 0xb7, 0x00, 0xca, 0xba, 0x7e, 0x3e, 0x1e, 0x0d, 0x44, 0x24, 0x37, 0xa1,
	0xc9, 0x8e, 0xd3, 0xb0, 0x32, 0x97, 0x3b, 0x26, 0xc5, 0x7b, 0x51, 0x7d, 0x90, 0xa7, 0xe1, 0x2a,
	0xcf, 0x50, 0xca, 0xef, 0x28, 0x4d, 0x35, 0x8a, 0x1a, 0xf3, 0xac, 0xcf, 0xe2, 0x35, 0xe6, 0x4b,
	0xa0, 0x4b, 0x26, 0x13, 0x75, 0xb9, 0x01, 0x0d, 0x96, 0xcb, 0xa8, 0x31, 0xaf, 0xbe, 0xa1, 0x10,
	0x34, 0x8a, 0xe6, 0x43, 0xf5, 0x2c, 0x86, 0xd3, 0x3f, 0x6a, 0x70, 0x30, 0xdd, 0x57, 0xc7, 0xdb,
	0xb6, 0x1d, 0x15, 0x9a, 0x94, 0x49, 0xb0, 0x8f, 0xa3, 0x42, 0xab, 0xc0, 0xef, 0xd4, 0x8b, 0xc5,
	0xa1, 0x3a, 0xde, 0x3e, 0x48, 0x62, 0x85, 0x27, 0xbe, 0x35, 0x7a, 0x72, 0x6b, 0x90, 0xdf, 0xf7,
	0x8f, 0xe4, 0x69, 0xa0, 0x51, 0x44, 0xf2, 0x15, 0xc4, 0x99, 0xb5, 0xe9, 0x47, 0x74, 0x81, 0x12,
	0xa5, 0x59, 0xbc, 0xb3, 0x9e, 0x02, 0x59, 0x23, 0x2a, 0xac, 0xe6, 0xd6, 0xd1, 0x17, 0x6b, 0x82,
	0xd2, 0x7a, 0xd2, 0x46, 0x13, 0xd0, 0x61, 0xca, 0x94, 0xa8, 0x72, 0xc7, 0xbf, 0x53, 0x1a, 0xf2,
	0xdb, 0xe1, 0x35, 0xaa, 0x54, 0xac, 0x4a, 0x01, 0x1b, 0x1a, 0x4d, 0x36, 0xcf, 0xd4, 0xb8, 0xa7,
	0x05, 0xa4, 0x85, 0x3e, 0xdc, 0xf1, 0x87, 0x46, 0x09, 0xaf, 0xe3, 0x15, 0xc4, 0x8b, 0xf8, 0x92,
	0x5a, 0xe7, 0xf1, 0x1d, 0x7a, 0xab, 0xc7, 0x65, 0x2f, 0x0d, 0xb9, 0x0f, 0x7b, 0x8f, 0xf1, 0x12,
	0xdb, 0x94, 0xc7, 0x70, 0x48, 0x23, 0x95, 0xe1, 0xcf, 0x7c, 0x56, 0xdf, 0x5e, 0x23, 0x2f, 0x72,
	0x89, 0x01, 0x6e, 0x8e, 0x27, 0xbd, 0xb8, 0x2f, 0xac, 0x1f, 0x3b, 0x14, 0xeb, 0x32, 0x86, 0x1d,
	0xce, 0x5c, 0x39, 0x35, 0xe9, 0x25, 0x4a, 0xe3, 0x9d, 0xb3, 0x43, 0xd2, 0x28, 0x36, 0x58, 0xc9,
	0x95, 0x7f, 0xaf, 0xc2, 0xd8, 0x29, 0xdd, 0xfb, 0x4c, 0xa6, 0x6d, 0xb5, 0x1d, 0x3b, 0xb1, 0xc9,
	0x5d, 0x19, 0x7b, 0x6d, 0x43, 0xaf, 0xb0, 0xc1, 0x8b, 0x2d, 0xf9, 0x7f, 0x78, 0x4d, 0xbe, 0xa5,
	0x92, 0xcf, 0x99, 0xb3, 0x63, 0x93, 0x7e, 0x30, 0x34, 0xb4, 0x6e, 0xb4, 0x74, 0xf4, 0x36, 0xdf,
	0x3b, 0xf9, 0x4b, 0x57, 0x6e, 0x51, 0x08, 0xf9, 0x12, 0x76, 0xe7, 0xe1, 0x12, 0xf9, 0x4c, 0xee,
	0xc2, 0x33, 0xf2, 0x37, 0xdc, 0x3d, 0x99, 0x6c, 0x66, 0x26, 0x24, 0xf7, 0x83, 0x13, 0xf4, 0xb7,
	0x05, 0x2e, 0x4f, 0xfe, 0x5c, 0xbe, 0x86, 0x03, 0x56, 0xae, 0xd4, 0x17, 0x7c, 0xca, 0x71, 0x87,
	0xd7, 0xc6, 0xc0, 0x7b, 0x1b, 0xba, 0xb8, 0xbc, 0xe2, 0x5d, 0xfe, 0x8a, 0x8c, 0xed, 0x93, 0x09,
	0x98, 0x5e, 0x69, 0xe5, 0x3d, 0x7a, 0xb1, 0x27, 0xd7, 0xa1, 0x4e, 0xbe, 0x97, 0x2b, 0x57, 0x88,
	0x17, 0x7c, 0x7f, 0x23, 0x3b, 0x0e, 0x79, 0x5b, 0x5b, 0xff, 0xaf, 0xf2, 0xb8, 0x75, 0x0b, 0x75,
	0xbc, 0x3f, 0xcb, 0x5c, 0x91, 0xfc, 0xf2, 0x7d, 0x46, 0x21, 0x1f, 0x0f, 0xce, 0x12, 0x3b, 0x3a,
	0xbf, 0x30, 0x38, 0x70, 0xea, 0xbc, 0x87, 0xee, 0x37, 0x4a, 0xb0, 0x6d, 0xad, 0x4b, 0xc9, 0xa8,
	0x60, 0xdd, 0x39, 0xa3, 0xe7, 0x4f, 0xfd, 0x0f, 0xfc, 0x59, 0xa9, 0x76, 0xfb, 0x57, 0x83, 0xb5,
	0xf2, 0x37, 0xfd, 0xed, 0x3f, 0x01, 0x00, 0x00, 0xff, 0xff, 0xde, 0x49, 0x75, 0xb6, 0x2c, 0x06,
	0x00, 0x00,
}