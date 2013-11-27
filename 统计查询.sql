

SELECT MWH1.zRegionCode,MWH2.* FROM PubSourceInfo MWH,PubRegionDef MWH1,
(
SELECT A.ZSOURCEID,1 XH,A.ZSOURCENAME,'基本信息' BT,NULL AS DT,NULL AS NO,C.ZTITLE
FROM PUBSOURCEINFO A,zAttachmentList C
WHERE C.zTableName = 'PUBSOURCEINFO' AND A.ZSOURCEID  = C.zGroupID
UNION ALL

SELECT A.ZSOURCEID,2 XH,A.ZSOURCENAME,'环保审批' BT,B.zApprovalDate AS DT ,B.zApprovalFileNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A,PubEnvApproval B,zAttachmentList C
WHERE A.ZSOURCEID = B.ZSOURCEID(+) AND C.zTableName = UPPER('PubEnvApproval') AND B.zProvalID = C.ZRID
UNION ALL

SELECT A.ZSOURCEID,3 XH,A.ZSOURCENAME,'试运行' BT,B.zApprovalDate AS DT ,B.zApprovalFileNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A,PubPreoperation B,zAttachmentList C
WHERE A.ZSOURCEID = B.ZSOURCEID(+) AND C.zTableName = UPPER('PubPreoperation') AND B.zPreoperationID	= C.ZRID
  
UNION ALL

SELECT A.ZSOURCEID,4 XH,A.ZSOURCENAME,'环境验收' BT,B.zAcceptanceDate AS DT ,B.zAcceptanceFileNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A,PubEnvAcceptance B,zAttachmentList C
WHERE A.ZSOURCEID = B.ZSOURCEID(+) AND C.zTableName = UPPER('PubEnvAcceptance') AND B.zAcceptanceID	= C.ZRID  

UNION ALL

SELECT A.ZSOURCEID,5 XH,A.ZSOURCENAME,'在线监控设备验收' BT,B.zAcceptanceDate AS DT ,B.zAcceptanceFileNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A, PubOnlineDevAcceptance B,zAttachmentList C
WHERE A.ZSOURCEID = B.ZSOURCEID(+) AND C.zTableName = UPPER('PubOnlineDevAcceptance') AND B.zAcceptanceID	= C.ZRID  

UNION ALL

SELECT A.ZSOURCEID,5 XH,A.ZSOURCENAME,'企业排污许可证' BT,B.zPeriodStartDate AS DT ,B.zLicenseNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A, PubPollutantLicense B,zAttachmentList C
WHERE A.ZSOURCEID = B.ZSOURCEID(+) AND C.zTableName = UPPER('PubPollutantLicense') AND B.zLicenseID	= C.ZRID  

UNION ALL

SELECT A.ZSOURCEID,6 XH,A.ZSOURCENAME,'危险废物转移' BT,B.zTransferDate AS DT ,B.zTransferNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A, PubScrapTransfer B,zAttachmentList C
WHERE A.ZSOURCEID = B.ZSOURCEID(+) AND C.zTableName = UPPER('PubScrapTransfer') AND B.zTransferID	= C.ZRID  

UNION ALL

SELECT A.ZSOURCEID,6 XH,A.ZSOURCENAME,'' BT,B.zTransferDate AS DT ,B.zTransferNo AS NO,C.ZTITLE
FROM PUBSOURCEINFO A, PubIllegalRecord B, PubFieldInvestigation C, zAttachmentList D
WHERE A.ZSOURCEID = B.ZSOURCEID(+)
  AND B.zIllegalID = C.zIllegalID(+) 
  AND C.zTableName = UPPER('PubFieldInvestigation') 
  AND C.zInvestigationID	= C.ZRID

) MWH2
WHERE MWH.ZSOURCEID = MWH2.ZSOURCEID(+)
  AND MWH.zRegionID = MWH1.zRegionID 
  AND MWH.ZSOURCEID != 2583
ORDER BY MWH1.zRegionID,MWH2.ZSOURCEID,MWH2.XH
  
------------------------------------------------------------------------------------------------------------
SELECT MWH1.zRegionCode,MWH2.* FROM PubSourceInfo MWH,PubRegionDef MWH1,
(

SELECT A.ZSOURCEID,7 XH,A.ZSOURCENAME,'限期整改通知书' BT,B.zIllegalType,B.zDate yDate,C.zDate AS DT ,C.zIllegalDesc AS NO,D.ZTITLE
FROM PUBSOURCEINFO A, PubIllegalRecord B, PubLimitTimeRectify C, zAttachmentList D
WHERE A.ZSOURCEID = B.ZSOURCEID(+)
  AND B.zIllegalID = C.zIllegalID(+) 
  AND D.zTableName = UPPER('PubLimitTimeRectify') 
  AND C.zRectifyID = D.ZRID

UNION ALL

SELECT A.ZSOURCEID,7 XH,A.ZSOURCENAME,'限期整改通知书后督察' BT,B.zIllegalType,B.zDate yDate,C.zDate AS DT ,C.zCheckDesc AS NO,D.ZTITLE
FROM PUBSOURCEINFO A, PubIllegalRecord B, PubLimitTimeRectifyChk C, zAttachmentList D
WHERE A.ZSOURCEID = B.ZSOURCEID
  AND B.zIllegalID = C.zIllegalID
  AND D.zTableName = UPPER('PubLimitTimeRectifyChk') 
  AND C.zRectifyChkID = D.ZRID
  
UNION ALL
    
SELECT A.ZSOURCEID,8 XH,A.ZSOURCENAME,'立案处理' BT,B.zIllegalType,B.zDate yDate,C.zDate AS DT ,C.zIllegalDesc AS NO,D.ZTITLE
FROM PUBSOURCEINFO A, PubIllegalRecord B, PubRegisterCase C, zAttachmentList D
WHERE A.ZSOURCEID = B.ZSOURCEID(+)
  AND B.zIllegalID = C.zIllegalID(+) 
  AND D.zTableName = UPPER('PubRegisterCase') 
  AND C.zRegCaseID = D.ZRID	
	
) MWH2
WHERE MWH.ZSOURCEID = MWH2.ZSOURCEID
  AND MWH.zRegionID = MWH1.zRegionID 
  AND MWH.ZSOURCEID != 2583
ORDER BY MWH1.zRegionID,MWH2.ZSOURCEID,MWH2.XH


---------------------------------------------------------------------------------------------
  
SELECT A.*
FROM PUBSOURCEINFO A, PubIllegalRecord B, PubLimitTimeRectifyChk C
WHERE A.ZSOURCEID = B.ZSOURCEID
  AND B.zIllegalID = C.zIllegalID
  
  
  select *　FROM PubLimitTimeRectifyChk;
  
  SELECT * FROM zAttachmentList WHERE ZGROUPID= 1829;
  
  DELETE FROM zAttachmentList WHERE ZTITLE = '注册码.txt';
  
  SELECT ztablename FROM zAttachmentList group by ztablename;
  
  select * from zattachmentlist where ztablename = UPPER('PubRegisterCase');
  
  DESC PUBUSERINFO;

  
  select ztablename,count(*)  from zAttachmentList group by ztablename;
  
  update zAttachmentList set ztablename = UPPER(ztablename) where ztablename = 'PubEnvApproval'; 