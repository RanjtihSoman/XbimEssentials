// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralCurveMember : IIfcStructuralCurveMember
	{
		Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum IIfcStructuralCurveMember.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
              switch(PredefinedType)
              {
                  case IfcStructuralCurveTypeEnum.CABLE:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.CABLE;
                  case IfcStructuralCurveTypeEnum.COMPRESSION_MEMBER:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.COMPRESSION_MEMBER;
                  case IfcStructuralCurveTypeEnum.NOTDEFINED:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.NOTDEFINED;
                  case IfcStructuralCurveTypeEnum.PIN_JOINED_MEMBER:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.PIN_JOINED_MEMBER;
                  case IfcStructuralCurveTypeEnum.RIGID_JOINED_MEMBER:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.RIGID_JOINED_MEMBER;
                  case IfcStructuralCurveTypeEnum.TENSION_MEMBER:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.TENSION_MEMBER;
                  case IfcStructuralCurveTypeEnum.USERDEFINED:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.USERDEFINED;
                  default:
                      return Ifc4.StructuralAnalysisDomain.IfcStructuralCurveMemberTypeEnum.NOTDEFINED;
              }
                
				//##
			} 
		}
		IIfcDirection IIfcStructuralCurveMember.Axis 
		{ 
			get
			{
				//## Handle return of Axis for which no match was found
				//TODO: Handle return of Axis for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}

	//## Custom code
	//##
	}
}