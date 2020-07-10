--Updating record for TransactionID:DHA-F-0045895_1134-113401-166721UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c2f7ffd9-a43e-4490-97a3-325e55755458' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0045895_DHA-F-0045895_1134-113401-166721_1505419914501.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045895_1134-113401-166721')and trans_id = '25314328'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045895_1134-113401-166721'
AND ID = '25314328'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046871_1106-110602-447264UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c9968597-f86e-4deb-b956-78e294b2f8de' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0046871_DHA-F-0046871_1106-110602-447264_1505409897478.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046871_1106-110602-447264')and trans_id = '25312302'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046871_1106-110602-447264'
AND ID = '25312302'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH7_1124-112402-336199UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '72e0f916-d445-4e49-82bd-ce103e853c6c' 
,prior_auth_file_name = 'PBM_PA_INS013_MOH7_MOH7_1124-112402-336199_1505409863441.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH7_1124-112402-336199')and trans_id = '25312291'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH7_1124-112402-336199'
AND ID = '25312291'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046909-IB108363UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '76a0f1a0-1776-4e64-8c27-b367a2fdd325' 
,prior_auth_file_name = 'PBM_PA_INS017_DHA-F-0046909_DHA-F-0046909-IB108363_1505407954004.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046909-IB108363')and trans_id = '25311358'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046909-IB108363'
AND ID = '25311358'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046748_1016-101601-264287UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '894e65b5-6a6f-4264-a933-94c33a910874' 
,prior_auth_file_name = 'PBM_PA_TPA026_DHA-F-0046748_DHA-F-0046748_1016-101601-264287_1505407818968.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046748_1016-101601-264287')and trans_id = '25311320'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046748_1016-101601-264287'
AND ID = '25311320'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001586_1269-126902-29676UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'd667b695-28b7-45ce-9a6b-374b1bd2eede' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001586_DHA-F-0001586_1269-126902-29676_1505407826278.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001586_1269-126902-29676')and trans_id = '25311319'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001586_1269-126902-29676'
AND ID = '25311319'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH751_1283-128305-57092UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '6fc87840-d033-41f3-a9a9-acb5abb5376b' 
,prior_auth_file_name = 'PBM_PA_INS010_MOH751_MOH751_1283-128305-57092_1505407868461.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH751_1283-128305-57092')and trans_id = '25311300'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH751_1283-128305-57092'
AND ID = '25311300'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001429_1264-126403-49502UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '15f7d8e9-4931-4d6d-a6f1-ba93c1bdab08' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001429_DHA-F-0001429_1264-126403-49502_1505407819261.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001429_1264-126403-49502')and trans_id = '25311269'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001429_1264-126403-49502'
AND ID = '25311269'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001662_1280-128003-88588UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '1fab1d27-c5eb-4769-b0e2-fef3d390fd8d' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001662_DHA-F-0001662_1280-128003-88588_1505407764836.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001662_1280-128003-88588')and trans_id = '25311258'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001662_1280-128003-88588'
AND ID = '25311258'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001162_1248-124802-226467UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e35b15aa-f087-426d-ba06-40fb30d6b1cf' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001162_DHA-F-0001162_1248-124802-226467_1505407826279.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001162_1248-124802-226467')and trans_id = '25311257'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001162_1248-124802-226467'
AND ID = '25311257'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001087_1239-123902-497133UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a1d6b685-8a14-4ed7-8286-e2e9ff2e8438' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0001087_DHA-F-0001087_1239-123902-497133_1505406985705.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001087_1239-123902-497133')and trans_id = '25310773'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001087_1239-123902-497133'
AND ID = '25310773'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000310_1202-120203-106281UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '824f31e7-b1d1-4777-8610-19ed61032f90' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000310_DHA-F-0000310_1202-120203-106281_1505406320972.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000310_1202-120203-106281')and trans_id = '25310505'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000310_1202-120203-106281'
AND ID = '25310505'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001122_1240-124010-44720UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '5bacfa1b-90cc-4305-98dd-cb4d27ea575d' 
,prior_auth_file_name = 'PBM_PA_TPA016_DHA-F-0001122_DHA-F-0001122_1240-124010-44720_1505406304468.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001122_1240-124010-44720')and trans_id = '25310500'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001122_1240-124010-44720'
AND ID = '25310500'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001662_1280-128008-123743UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '26678fda-8fb6-4236-a04b-34465a273e7c' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001662_DHA-F-0001662_1280-128008-123743_1505406304469.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001662_1280-128008-123743')and trans_id = '25310499'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001662_1280-128008-123743'
AND ID = '25310499'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045815_016066A-HCH3-97669UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '641d90a0-c60f-4118-9205-e63253308d8d' 
,prior_auth_file_name = 'PBM_PA_INS017_DHA-F-0045815_DHA-F-0045815_016066A-HCH3-97669_1505406351235.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045815_016066A-HCH3-97669')and trans_id = '25310492'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045815_016066A-HCH3-97669'
AND ID = '25310492'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047958_1169-116901-378291UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'fc7a6934-a42d-40bb-9094-27391af728f8' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0047958_DHA-F-0047958_1169-116901-378291_1505406304453.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047958_1169-116901-378291')and trans_id = '25310491'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047958_1169-116901-378291'
AND ID = '25310491'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001029_1237-123702-616386UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'd4f713c6-434e-4b60-83eb-70c039efbbf8' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0001029_DHA-F-0001029_1237-123702-616386_1505406304455.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001029_1237-123702-616386')and trans_id = '25310489'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001029_1237-123702-616386'
AND ID = '25310489'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000939DPP7071136UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'bf1c3f50-0c71-4899-b5b8-2821dcec8dfb' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000939_DHA-F-0000939DPP7071136_1501504747493.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000939DPP7071136')and trans_id = '24456534'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000939DPP7071136'
AND ID = '24456534'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000902_IOBPA001_EN02416388_197600UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'f8c93f04-1c4f-4079-b8fd-eeee39efb532' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000902_DHA-F-0000902_IOBPA001_EN02416388_197600_1501498454759.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000902_IOBPA001_EN02416388_197600')and trans_id = '24454644'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000902_IOBPA001_EN02416388_197600'
AND ID = '24454644'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000337_1203-120311-458197UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0dbb9ae7-ae97-46b3-b67f-4bd65d208314' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000337_DHA-F-0000337_1203-120311-458197_1501278049205.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000337_1203-120311-458197')and trans_id = '24400188'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000337_1203-120311-458197'
AND ID = '24400188'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000775-INS012-20170729013054UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '5563da99-f6e5-4e02-a116-e60992a71295' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000775_DHA-F-0000775-INS012-20170729013054_1501277496983.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000775-INS012-20170729013054')and trans_id = '24400171'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000775-INS012-20170729013054'
AND ID = '24400171'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000934_1222-122201-550838UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'ce2e7d36-8bde-49a7-bc37-d5ec71e8e54f' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000934_DHA-F-0000934_1222-122201-550838_1501190691160.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000934_1222-122201-550838')and trans_id = '24390429'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000934_1222-122201-550838'
AND ID = '24390429'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH1789_1204-120402-285494UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '924ab175-8e7d-400c-8d7b-b359b5d832d1' 
,prior_auth_file_name = 'PBM_PA_INS012_MOH1789_MOH1789_1204-120402-285494_1501189607745.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH1789_1204-120402-285494')and trans_id = '24390399'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH1789_1204-120402-285494'
AND ID = '24390399'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045834-INS013-20170718012308UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'da476c9e-44c5-442e-a66d-b9a1d0ff5285' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0045834_DHA-F-0045834-INS013-20170718012308_1500326594636.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045834-INS013-20170718012308')and trans_id = '24189427'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045834-INS013-20170718012308'
AND ID = '24189427'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046625_1013-101302-20550UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e7f9b189-91d8-4b9b-824e-bf1ed817feaa' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0046625_DHA-F-0046625_1013-101302-20550_1500326546909.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046625_1013-101302-20550')and trans_id = '24189425'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046625_1013-101302-20550'
AND ID = '24189425'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045834-INS013-20170718011614UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9530f723-a70d-455f-93a3-e53a88b9c660' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0045834_DHA-F-0045834-INS013-20170718011614_1500326188815.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045834-INS013-20170718011614')and trans_id = '24189415'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045834-INS013-20170718011614'
AND ID = '24189415'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000775-INS013-20170712093840UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '733997b6-04dc-4da7-909b-40eb73ad2cab' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000775_DHA-F-0000775-INS013-20170712093840_1499837942931.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000775-INS013-20170712093840')and trans_id = '24071642'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000775-INS013-20170712093840'
AND ID = '24071642'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH1421_1043-104302-145868UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '747f4d61-ffe8-4e4e-ab36-fcad821332b7' 
,prior_auth_file_name = 'PBM_PA_INS012_MOH1421_MOH1421_1043-104302-145868_1497260761012.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH1421_1043-104302-145868')and trans_id = '23495083'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH1421_1043-104302-145868'
AND ID = '23495083'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000386_1069-106901-98908UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'aa851c9f-e902-4e26-aa74-4339e70354d9' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000386_DHA-F-0000386_1069-106901-98908_1497117587002.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000386_1069-106901-98908')and trans_id = '23460931'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000386_1069-106901-98908'
AND ID = '23460931'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001706-INS013-20170610155926UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'bd36dbb2-825e-4635-bb63-4da547e4f227' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001706_DHA-F-0001706-INS013-20170610155926_1497096028421.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001706-INS013-20170610155926')and trans_id = '23450646'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001706-INS013-20170610155926'
AND ID = '23450646'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000310_1202-120202-380599UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'ca5e6a9f-5cd3-4d8d-b459-18b20b964b9e' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0000310_DHA-F-0000310_1202-120202-380599_1497026715967.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000310_1202-120202-380599')and trans_id = '23434853'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000310_1202-120202-380599'
AND ID = '23434853'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047173_1192-119201-287120UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'f6bcb1c9-e453-42ee-b700-881bad0e9190' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0047173_DHA-F-0047173_1192-119201-287120_1497018600354.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047173_1192-119201-287120')and trans_id = '23433338'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047173_1192-119201-287120'
AND ID = '23433338'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045788_1178-117803-214530UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e9dcc29b-3fe9-4a13-9da1-663c49199f51' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0045788_DHA-F-0045788_1178-117803-214530_1497008852859.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045788_1178-117803-214530')and trans_id = '23431610'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045788_1178-117803-214530'
AND ID = '23431610'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000337_1203-120311-431281UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '175a4bf7-286e-46b2-acdf-1cc7224fbbf3' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000337_DHA-F-0000337_1203-120311-431281_1496980891015.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000337_1203-120311-431281')and trans_id = '23428112'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000337_1203-120311-431281'
AND ID = '23428112'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000823-13701998UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c40bef6b-0a44-47d0-9d98-b18621172f17' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000823_DHA-F-0000823-13701998_1496977906823.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000823-13701998')and trans_id = '23428079'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000823-13701998'
AND ID = '23428079'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001074_1236-123602-292594UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '594e8f7d-1327-45aa-a49f-0b61f475e2d1' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0001074_DHA-F-0001074_1236-123602-292594_1496951572807.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001074_1236-123602-292594')and trans_id = '23427229'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001074_1236-123602-292594'
AND ID = '23427229'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047116_1181-118101-202083UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0fb83c4a-fd99-4835-92c2-ed5654131a03' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0047116_DHA-F-0047116_1181-118101-202083_1496950028207.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047116_1181-118101-202083')and trans_id = '23426878'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047116_1181-118101-202083'
AND ID = '23426878'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047958_1169-116901-343699UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0d6071e1-50fd-4cdf-b369-88dfb38d16f8' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0047958_DHA-F-0047958_1169-116901-343699_1496938338848.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047958_1169-116901-343699')and trans_id = '23421797'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047958_1169-116901-343699'
AND ID = '23421797'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000792-INS013-20170608133933UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e0e30981-9451-4efc-91ae-166d45ce5868' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000792_DHA-F-0000792-INS013-20170608133933_1496914800897.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000792-INS013-20170608133933')and trans_id = '23413229'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000792-INS013-20170608133933'
AND ID = '23413229'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045834-INS013-20170608133935UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9496c7c5-2d60-4b7e-9faa-8b50599222c2' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0045834_DHA-F-0045834-INS013-20170608133935_1496914799655.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045834-INS013-20170608133935')and trans_id = '23413221'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045834-INS013-20170608133935'
AND ID = '23413221'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000775-INS012-20170608133857UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '4e0be804-0165-40bb-a16e-3351f23f0c85' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000775_DHA-F-0000775-INS012-20170608133857_1496914745871.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000775-INS012-20170608133857')and trans_id = '23413190'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000775-INS012-20170608133857'
AND ID = '23413190'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000967_1096-109602-107183UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e1a9dbcd-3d21-499a-902c-982ee6e54d7c' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0000967_DHA-F-0000967_1096-109602-107183_1496864367705.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000967_1096-109602-107183')and trans_id = '23405358'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000967_1096-109602-107183'
AND ID = '23405358'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046858_1159-115901-302820UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'd5e895bc-c651-41a7-b90a-17c394715068' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0046858_DHA-F-0046858_1159-115901-302820_1496863062222.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046858_1159-115901-302820')and trans_id = '23405037'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046858_1159-115901-302820'
AND ID = '23405037'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046358_1111-111103-329186UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '69fd0efa-2e6f-4a54-bca7-a1aae5a02ba7' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0046358_DHA-F-0046358_1111-111103-329186_1496862218208.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046358_1111-111103-329186')and trans_id = '23404731'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046358_1111-111103-329186'
AND ID = '23404731'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046871_1106-110603-453647UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '3685d9ab-dbbd-4faf-b340-d1a4c6fd642a' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0046871_DHA-F-0046871_1106-110603-453647_1496860151012.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046871_1106-110603-453647')and trans_id = '23403823'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046871_1106-110603-453647'
AND ID = '23403823'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000854_1215-121501-195198UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a7032263-92d1-482e-9435-914e3a0f9359' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000854_DHA-F-0000854_1215-121501-195198_1496853181972.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000854_1215-121501-195198')and trans_id = '23400106'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000854_1215-121501-195198'
AND ID = '23400106'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047690_1140-114004-321047UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '285784d2-57e5-46a2-81e7-f323bce2f3f4' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0047690_DHA-F-0047690_1140-114004-321047_1496844501820.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047690_1140-114004-321047')and trans_id = '23396865'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047690_1140-114004-321047'
AND ID = '23396865'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000337_1203-120301-403787UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0f076e1d-1e0a-436a-98a0-1ea978b8ef16' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000337_DHA-F-0000337_1203-120301-403787_1496787565970.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000337_1203-120301-403787')and trans_id = '23384688'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000337_1203-120301-403787'
AND ID = '23384688'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045815_016066A-HCH3-68428UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a73af25b-9d14-48c6-bcef-2c6db3fcde09' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0045815_DHA-F-0045815_016066A-HCH3-68428_1496787226014.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045815_016066A-HCH3-68428')and trans_id = '23384674'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045815_016066A-HCH3-68428'
AND ID = '23384674'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001015-TPA013-20170606224234UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0392caae-6cdb-4fc0-bcc9-e7e1c55223d3' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0001015_DHA-F-0001015-TPA013-20170606224234_1496774595386.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001015-TPA013-20170606224234')and trans_id = '23382665'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001015-TPA013-20170606224234'
AND ID = '23382665'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:CL-PH-0005-08-13553956UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0480cc7a-68b1-4f23-8663-8d8f3c5a31bc' 
,prior_auth_file_name = 'PBM_PA_INS017_CL-PH-0005-08_CL-PH-0005-08-13553956_1496214011149.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'CL-PH-0005-08-13553956')and trans_id = '23244910'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'CL-PH-0005-08-13553956'
AND ID = '23244910'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047690_1140-114007-45676UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '768a7b50-d253-455b-8e94-8efaf46f15c6' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0047690_DHA-F-0047690_1140-114007-45676_1496214013889.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047690_1140-114007-45676')and trans_id = '23244906'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047690_1140-114007-45676'
AND ID = '23244906'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000909_1219-121901-270102UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '3e78223f-2667-4d7e-8711-bfbb248db5fa' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0000909_DHA-F-0000909_1219-121901-270102_1496214013890.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000909_1219-121901-270102')and trans_id = '23244903'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000909_1219-121901-270102'
AND ID = '23244903'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000909_1219-121901-270100UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '3c51a115-a56d-48d2-8ae5-4685c135d810' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0000909_DHA-F-0000909_1219-121901-270100_1496214016549.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000909_1219-121901-270100')and trans_id = '23244887'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000909_1219-121901-270100'
AND ID = '23244887'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0048025_1174-117401-239191UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'd9d78784-a6dd-4aa4-8d65-9134fdd16d68' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0048025_DHA-F-0048025_1174-117401-239191_1495991184230.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0048025_1174-117401-239191')and trans_id = '23193751'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0048025_1174-117401-239191'
AND ID = '23193751'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000823-13430169UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '5c1b08a3-e7b3-4e94-85df-843f0bf922a9' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000823_23094366_1495573323676.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000823-13430169')and trans_id = '23094366'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000823-13430169'
AND ID = '23094366'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000348-TPA013-20170520205905UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c09d8f03-8b11-4fdb-bd57-90a58a2cd9a6' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0000348_23013880_1495299671132.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000348-TPA013-20170520205905')and trans_id = '23013880'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000348-TPA013-20170520205905'
AND ID = '23013880'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047173_1192-119201-278804UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a1734b02-6b8f-4d56-85ff-627ea797c799' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0047173_DHA-F-0047173_1192-119201-278804_1495197673593.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047173_1192-119201-278804')and trans_id = '22981419'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047173_1192-119201-278804'
AND ID = '22981419'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045914-TPA026-20170516134831UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '35648e41-4d7b-4b44-8073-9da569ddd1b0' 
,prior_auth_file_name = 'PBM_PA_TPA026_DHA-F-0045914_DHA-F-0045914-TPA026-20170516134831_1494928146728.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045914-TPA026-20170516134831')and trans_id = '22912590'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045914-TPA026-20170516134831'
AND ID = '22912590'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000902_IHNET001_EN02367924_168705UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'ce71a20a-d7dd-43f1-acc7-25c22e450690' 
,prior_auth_file_name = 'PBM_PA_INS038_DHA-F-0000902_DHA-F-0000902_IHNET001_EN02367924_168705_1494918470648.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000902_IHNET001_EN02367924_168705')and trans_id = '22907557'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000902_IHNET001_EN02367924_168705'
AND ID = '22907557'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH1819-INS012-20170516105010UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'b536aa6a-9d86-459c-8922-2489f37b2cf8' 
,prior_auth_file_name = 'PBM_PA_INS012_MOH1819_MOH1819-INS012-20170516105010_1494917450429.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH1819-INS012-20170516105010')and trans_id = '22907002'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH1819-INS012-20170516105010'
AND ID = '22907002'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:CL-PH-0002-07_016029A-HCC5-61021UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'b8e1d1db-e776-4329-8869-6a73a62af0a0' 
,prior_auth_file_name = 'PBM_PA_INS012_CL-PH-0002-07_CL-PH-0002-07_016029A-HCC5-61021_1494916827473.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'CL-PH-0002-07_016029A-HCC5-61021')and trans_id = '22906628'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'CL-PH-0002-07_016029A-HCC5-61021'
AND ID = '22906628'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045776_1107-110703-337911UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'cca439fe-3a28-4e28-a80c-8a38c9cab5f0' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0045776_DHA-F-0045776_1107-110703-337911_1494913669925.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045776_1107-110703-337911')and trans_id = '22905332'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045776_1107-110703-337911'
AND ID = '22905332'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001551-60184070-P-001UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '2c0734b9-2325-433f-980d-9c5b1ec90b67' 
,prior_auth_file_name = 'PBM_PA_TPA026_DHA-F-0001551_DHA-F-0001551-60184070-P-001_1493892544647.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001551-60184070-P-001')and trans_id = '22630580'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001551-60184070-P-001'
AND ID = '22630580'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001196-INS012-20170427101219UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a2c164d9-fcdc-4802-b67a-46d0fa1647d4' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0001196_DHA-F-0001196-INS012-20170427101219_1493273585312.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001196-INS012-20170427101219')and trans_id = '22460042'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001196-INS012-20170427101219'
AND ID = '22460042'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000891_1216-121602-229684UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e00a25be-b162-49e8-9f48-a6d53997d35f' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000891_DHA-F-0000891_1216-121602-229684_1493217121950.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000891_1216-121602-229684')and trans_id = '22448321'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000891_1216-121602-229684'
AND ID = '22448321'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000823-12817692UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '7fb83a3e-75e6-41a9-bfe7-c85c4e8eaf2c' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000823_22359034_1492898470206.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000823-12817692')and trans_id = '22359034'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000823-12817692'
AND ID = '22359034'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045623_A_431308_1492870604375UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'de53f319-4db5-47b2-9116-16c782534e65' 
,prior_auth_file_name = 'eAuth_INS028_DHA-F-0045623_1492870612495.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045623_A_431308_1492870604375')and trans_id = '22350110'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045623_A_431308_1492870604375'
AND ID = '22350110'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045623_A_431308_1492870605500UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '66f018ef-efc0-47ec-be49-9c03c745c09f' 
,prior_auth_file_name = 'eAuth_INS028_DHA-F-0045623_1492870610056.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045623_A_431308_1492870605500')and trans_id = '22350109'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045623_A_431308_1492870605500'
AND ID = '22350109'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045623_A_431296_1492840459652UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '672e45b9-6b7d-41dc-b41a-937180fe8ea2' 
,prior_auth_file_name = 'eAuth_INS028_DHA-F-0045623_1492840465848.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045623_A_431296_1492840459652')and trans_id = '22334536'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045623_A_431296_1492840459652'
AND ID = '22334536'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001605-TPA021-20170417102241UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'b09958d4-3181-428f-92f0-a0cf3901a4f4' 
,prior_auth_file_name = 'PBM_PA_TPA021_DHA-F-0001605_DHA-F-0001605-TPA021-20170417102241_1492410198513.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001605-TPA021-20170417102241')and trans_id = '22218979'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001605-TPA021-20170417102241'
AND ID = '22218979'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001196-TPA032-20170412202017UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a2b77fec-394e-434a-af70-3c4932a9ede9' 
,prior_auth_file_name = 'PBM_PA_TPA032_DHA-F-0001196_DHA-F-0001196-TPA032-20170412202017_1492014125648.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001196-TPA032-20170412202017')and trans_id = '22123315'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001196-TPA032-20170412202017'
AND ID = '22123315'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045623_A_430085_1491983266397UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'df3763c8-2d60-4fb3-bc93-3d0ee6b29d41' 
,prior_auth_file_name = 'eAuth_INS028_DHA-F-0045623_1491983271134.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045623_A_430085_1491983266397')and trans_id = '22109398'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045623_A_430085_1491983266397'
AND ID = '22109398'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047032-INS028-20170411183009UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '55d19977-3db9-4e60-8c8a-a6a81305cc9c' 
,prior_auth_file_name = 'eAuth_INS028_DHA-F-0047032_1491921017018.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047032-INS028-20170411183009')and trans_id = '22095304'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047032-INS028-20170411183009'
AND ID = '22095304'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH2598_1126-112601-178713UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9cc3ba58-340e-4e48-950a-b5ebb8055f81' 
,prior_auth_file_name = 'PBM_PA_INS010_MOH2598_MOH2598_1126-112601-178713_1491742308826.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH2598_1126-112601-178713')and trans_id = '22039366'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH2598_1126-112601-178713'
AND ID = '22039366'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000902_IATNA003_EN02242415_153066UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'f0a87bca-9623-4c1c-9dee-427ccbd23278' 
,prior_auth_file_name = 'PBM_PA_INS028_DHA-F-0000902_DHA-F-0000902_IATNA003_EN02242415_153066_1491723357308.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000902_IATNA003_EN02242415_153066')and trans_id = '22030474'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000902_IATNA003_EN02242415_153066'
AND ID = '22030474'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000823-12561680UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '299e5d18-3159-4117-abf3-2c18eace0a40' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000823_DHA-F-0000823-12561680_1491723202948.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000823-12561680')and trans_id = '22030433'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000823-12561680'
AND ID = '22030433'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000415_1072-107202-129280UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '7c437c8d-16b6-41ec-bc84-e9600b0461ff' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000415_DHA-F-0000415_1072-107202-129280_1491723035870.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000415_1072-107202-129280')and trans_id = '22030357'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000415_1072-107202-129280'
AND ID = '22030357'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045768_1003-100302-150535UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'b5e91e7f-e53d-4eac-b442-3ce53f54b337' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0045768_DHA-F-0045768_1003-100302-150535_1491722707046.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045768_1003-100302-150535')and trans_id = '22030203'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045768_1003-100302-150535'
AND ID = '22030203'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:CL-PH-0005-08-12560328UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '085be261-1ee6-4901-92ff-c6acdfc6165f' 
,prior_auth_file_name = 'PBM_PA_INS010_CL-PH-0005-08_CL-PH-0005-08-12560328_1491722060328.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'CL-PH-0005-08-12560328')and trans_id = '22029855'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'CL-PH-0005-08-12560328'
AND ID = '22029855'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001184-INS013-20170409015529UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'e1b2370a-1b44-486e-816a-b2a813602f00' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001184_22026173_1491688534359.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001184-INS013-20170409015529')and trans_id = '22026174'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001184-INS013-20170409015529'
AND ID = '22026174'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000792-INS012-20170408233252UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9de28870-0153-43da-9c8b-c47c0291ba86' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000792_DHA-F-0000792-INS012-20170408233252_1491680080550.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000792-INS012-20170408233252')and trans_id = '22025766'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000792-INS012-20170408233252'
AND ID = '22025766'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0048039_1056-105601-102474UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '1c9b43cf-4d2b-4474-a706-06e3916a6849' 
,prior_auth_file_name = 'PBM_PA_TPA033_DHA-F-0048039_DHA-F-0048039_1056-105601-102474_1491679620151.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0048039_1056-105601-102474')and trans_id = '22025709'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0048039_1056-105601-102474'
AND ID = '22025709'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000807-12546861UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c64a42dc-289a-48da-a303-6aa50b62bbbf' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000807_DHA-F-0000807-12546861_1491657509717.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000807-12546861')and trans_id = '22013549'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000807-12546861'
AND ID = '22013549'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047958_1169-116901-317377UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'd5b4db78-3dec-45e4-b9f7-5297db9e72e3' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0047958_DHA-F-0047958_1169-116901-317377_1491657503654.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047958_1169-116901-317377')and trans_id = '22013510'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047958_1169-116901-317377'
AND ID = '22013510'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000462_1206-120602-429630UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '844d041f-14ac-47eb-bf85-74b0888dd3df' 
,prior_auth_file_name = 'PBM_PA_TPA032_DHA-F-0000462_DHA-F-0000462_1206-120602-429630_1491657399014.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000462_1206-120602-429630')and trans_id = '22013507'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000462_1206-120602-429630'
AND ID = '22013507'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000689-INS017-20170408170839UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9c0314c9-94f2-46c8-86b9-ffd717de3cec' 
,prior_auth_file_name = 'PBM_PA_INS017_DHA-F-0000689_DHA-F-0000689-INS017-20170408170839_1491657052935.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000689-INS017-20170408170839')and trans_id = '22013348'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000689-INS017-20170408170839'
AND ID = '22013348'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046630_1039-103902-91588UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '451a3547-f625-437e-9fd2-e144d63675b1' 
,prior_auth_file_name = 'PBM_PA_INS028_DHA-F-0046630_DHA-F-0046630_1039-103902-91588_1491656874421.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046630_1039-103902-91588')and trans_id = '22013269'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046630_1039-103902-91588'
AND ID = '22013269'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047767_1143-114301-302084UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '7ba8cbd0-c601-41df-8148-c9eb3348bfc0' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0047767_DHA-F-0047767_1143-114301-302084_1491656873436.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047767_1143-114301-302084')and trans_id = '22013268'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047767_1143-114301-302084'
AND ID = '22013268'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001064_1100-110001-9702UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '77c4b05a-4aad-4e32-891e-9f668976cc9b' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0001064_DHA-F-0001064_1100-110001-9702_1491656741874.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001064_1100-110001-9702')and trans_id = '22013237'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001064_1100-110001-9702'
AND ID = '22013237'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000615-INS028-20170408170044UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '5380a2fc-774b-48ed-a3e2-84ed0c183363' 
,prior_auth_file_name = 'PBM_PA_INS028_DHA-F-0000615_DHA-F-0000615-INS028-20170408170044_1491656595358.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000615-INS028-20170408170044')and trans_id = '22013164'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000615-INS028-20170408170044'
AND ID = '22013164'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:CL-PH-0002-07_016029A-HCC8-2841UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'cfdc4a57-0bc7-4ae0-89cb-4e8f1969738e' 
,prior_auth_file_name = 'PBM_PA_INS012_CL-PH-0002-07_CL-PH-0002-07_016029A-HCC8-2841_1491656018853.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'CL-PH-0002-07_016029A-HCC8-2841')and trans_id = '22012878'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'CL-PH-0002-07_016029A-HCC8-2841'
AND ID = '22012878'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000689-INS020-20170408165037UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c37a875b-8109-4867-b209-61c28da9f130' 
,prior_auth_file_name = 'PBM_PA_INS020_DHA-F-0000689_DHA-F-0000689-INS020-20170408165037_1491655997322.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000689-INS020-20170408165037')and trans_id = '22012865'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000689-INS020-20170408165037'
AND ID = '22012865'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045953_1184-118401-406859UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '0424296a-baa2-4a97-bb4c-a5a56e0ab211' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0045953_DHA-F-0045953_1184-118401-406859_1491655817743.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045953_1184-118401-406859')and trans_id = '22012793'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045953_1184-118401-406859'
AND ID = '22012793'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001184-INS013-20170408164054UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'fb10e189-0918-4695-8423-290c594a1e06' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001184_22012583_1491655259546.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001184-INS013-20170408164054')and trans_id = '22012596'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001184-INS013-20170408164054'
AND ID = '22012596'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0045953_1184-118401-406816UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'b62b2713-f9d6-473c-ac53-f952584df2ca' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0045953_DHA-F-0045953_1184-118401-406816_1491653341724.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0045953_1184-118401-406816')and trans_id = '22011703'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0045953_1184-118401-406816'
AND ID = '22011703'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0048021-INS010-20170408160427UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'ec55de3b-5c1d-4d47-80bf-4d2e5a978f91' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0048021_DHA-F-0048021-INS010-20170408160427_1491653229833.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0048021-INS010-20170408160427')and trans_id = '22011647'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0048021-INS010-20170408160427'
AND ID = '22011647'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001414_1262-126203-210478UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '57719936-aef4-4cd6-bcc0-486346275e42' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001414_DHA-F-0001414_1262-126203-210478_1491652967052.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001414_1262-126203-210478')and trans_id = '22011509'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001414_1262-126203-210478'
AND ID = '22011509'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000807-12542476_1UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '252fee97-d726-40ef-b3a2-40b9fa55129b' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000807_DHA-F-0000807-12542476_1_1491652883474.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000807-12542476_1')and trans_id = '22011475'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000807-12542476_1'
AND ID = '22011475'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000939DPP7033069UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '8ea0e517-fd3f-41b7-9a35-0683c9e12a60' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0000939_DHA-F-0000939DPP7033069_1491652281371.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000939DPP7033069')and trans_id = '22011261'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000939DPP7033069'
AND ID = '22011261'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000886_1217-121702-197374UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'afdc030f-0b59-4846-9536-3c48409980e9' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000886_DHA-F-0000886_1217-121702-197374_1491652281511.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000886_1217-121702-197374')and trans_id = '22011249'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000886_1217-121702-197374'
AND ID = '22011249'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047690_1140-114001-250271UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '4af4edfd-8d78-4bf7-a708-36e7a2a333e4' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0047690_DHA-F-0047690_1140-114001-250271_1491652239496.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047690_1140-114001-250271')and trans_id = '22011240'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047690_1140-114001-250271'
AND ID = '22011240'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:CL-PH-0002-07_016029A-HCC8-2810UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'b31ec31c-45a3-430d-85c5-4701a2a602b6' 
,prior_auth_file_name = 'PBM_PA_INS013_CL-PH-0002-07_CL-PH-0002-07_016029A-HCC8-2810_1491651962027.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'CL-PH-0002-07_016029A-HCC8-2810')and trans_id = '22011172'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'CL-PH-0002-07_016029A-HCC8-2810'
AND ID = '22011172'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000308-SAD11605UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9a6e701f-708a-4d8d-a90d-880c8fad63d2' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0000308_DHA-F-0000308-SAD11605_1491651486393.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000308-SAD11605')and trans_id = '22010952'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000308-SAD11605'
AND ID = '22010952'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001184-TPA013-20170408153503UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '573ec538-e578-4563-831c-74544acd3de2' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0001184_22010878_1491651315016.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001184-TPA013-20170408153503')and trans_id = '22010890'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001184-TPA013-20170408153503'
AND ID = '22010890'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000807-12543792UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'c9b2f0fe-3c16-4d67-9780-dc09052728eb' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000807_DHA-F-0000807-12543792_1491651406003.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000807-12543792')and trans_id = '22010872'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000807-12543792'
AND ID = '22010872'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000823-12543659UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '501444e3-11f2-4ee4-80c7-536cae1d28af' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000823_DHA-F-0000823-12543659_1491651298128.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000823-12543659')and trans_id = '22010858'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000823-12543659'
AND ID = '22010858'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000337_1203-120317-218498UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '85e6edb4-011b-4fdf-a291-0944fee6090f' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000337_DHA-F-0000337_1203-120317-218498_1491651311909.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000337_1203-120317-218498')and trans_id = '22010857'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000337_1203-120317-218498'
AND ID = '22010857'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001184-INS013-20170408153241UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '1bccd574-853d-49bf-b708-0530f8a1f98e' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001184_22010796_1491651167626.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001184-INS013-20170408153241')and trans_id = '22010829'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001184-INS013-20170408153241'
AND ID = '22010829'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000792-INS013-20170408151830UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '4ab94420-f14c-4d14-bc03-5e98be1a3446' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000792_DHA-F-0000792-INS013-20170408151830_1491650486179.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000792-INS013-20170408151830')and trans_id = '22010489'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000792-INS013-20170408151830'
AND ID = '22010489'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH7_1124-112402-282999UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '02d168b6-662a-427b-8138-e1a896dec07d' 
,prior_auth_file_name = 'PBM_PA_INS013_MOH7_MOH7_1124-112402-282999_1491650510679.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH7_1124-112402-282999')and trans_id = '22010474'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH7_1124-112402-282999'
AND ID = '22010474'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047612_1137-113704-126744UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '344c62ba-3b7f-4bac-8895-4f4dc2c0994e' 
,prior_auth_file_name = 'PBM_PA_INS028_DHA-F-0047612_DHA-F-0047612_1137-113704-126744_1491650419944.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047612_1137-113704-126744')and trans_id = '22010460'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047612_1137-113704-126744'
AND ID = '22010460'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000939DPP7033066UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '72cf963a-eedf-4260-8263-1ca284871ab4' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0000939_DHA-F-0000939DPP7033066_1491650443366.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000939DPP7033066')and trans_id = '22010446'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000939DPP7033066'
AND ID = '22010446'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001184-INS010-20170408151712UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '7b3baf19-6574-4c9b-9fd4-9d571281ece9' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0001184_22010391_1491650235313.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001184-INS010-20170408151712')and trans_id = '22010428'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001184-INS010-20170408151712'
AND ID = '22010428'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046254_1186-118602-267819UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '3f04c65c-5032-4e4d-ace4-ea26fff6ad6f' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0046254_DHA-F-0046254_1186-118602-267819_1491650190538.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046254_1186-118602-267819')and trans_id = '22010355'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046254_1186-118602-267819'
AND ID = '22010355'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000792-INS013-20170408151419UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '1fa5504c-0796-44c3-b28f-c1b225c557fa' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000792_DHA-F-0000792-INS013-20170408151419_1491650167819.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000792-INS013-20170408151419')and trans_id = '22010348'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000792-INS013-20170408151419'
AND ID = '22010348'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000902_IOBPA001_EN02338364_152760UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '6cd5e2ae-519c-47d4-a83b-1b05064e0a06' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0000902_DHA-F-0000902_IOBPA001_EN02338364_152760_1491649540171.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000902_IOBPA001_EN02338364_152760')and trans_id = '22009986'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000902_IOBPA001_EN02338364_152760'
AND ID = '22009986'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0000462_1206-120601-385389UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '978ec8f5-92f4-439a-83f2-55c58d99ff15' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0000462_DHA-F-0000462_1206-120601-385389_1491649359858.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0000462_1206-120601-385389')and trans_id = '22009927'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0000462_1206-120601-385389'
AND ID = '22009927'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:MOH1940_1238-123803-162383UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '3fa3f1ad-32e9-44c3-85ab-9a6da43b4bb2' 
,prior_auth_file_name = 'PBM_PA_INS012_MOH1940_MOH1940_1238-123803-162383_1491648455415.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'MOH1940_1238-123803-162383')and trans_id = '22009500'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'MOH1940_1238-123803-162383'
AND ID = '22009500'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0046858_1159-115901-267838UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'dd472aad-d3a7-4e7d-9433-e83197f4aac1' 
,prior_auth_file_name = 'PBM_PA_TPA013_DHA-F-0046858_DHA-F-0046858_1159-115901-267838_1491647744464.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0046858_1159-115901-267838')and trans_id = '22009230'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0046858_1159-115901-267838'
AND ID = '22009230'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001074_1236-123606-286025UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '6ef228cb-1094-4d0c-a6f2-46c1b99bacb2' 
,prior_auth_file_name = 'PBM_PA_INS013_DHA-F-0001074_DHA-F-0001074_1236-123606-286025_1491647766946.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001074_1236-123606-286025')and trans_id = '22009222'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001074_1236-123606-286025'
AND ID = '22009222'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0047379-INS010-20170408143408UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '9e1480bf-e9f5-4ad5-a40d-43bac2845cbc' 
,prior_auth_file_name = 'PBM_PA_INS010_DHA-F-0047379_DHA-F-0047379-INS010-20170408143408_1491647811997.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0047379-INS010-20170408143408')and trans_id = '22009221'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0047379-INS010-20170408143408'
AND ID = '22009221'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0001162_1248-124801-168251UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = 'a8dfe943-7d92-41ca-a12e-b1271acb850a' 
,prior_auth_file_name = 'PBM_PA_INS012_DHA-F-0001162_DHA-F-0001162_1248-124801-168251_1491647679798.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0001162_1248-124801-168251')and trans_id = '22009207'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0001162_1248-124801-168251'
AND ID = '22009207'
AND state_id = 2 AND trans_src = (4)
GO 

--Updating record for TransactionID:DHA-F-0048033-TPA026-20170323190848UPDATE TOP (1) POST_OFFICE_COMM 
SET prior_auth_file_id = '715f8234-c6a1-4b43-8520-cead0542735d' 
,prior_auth_file_name = 'PBM_PA_TPA026_DHA-F-0048033_DHA-F-0048033-TPA026-20170323190848_1490281771002.xml'
WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = 'DHA-F-0048033-TPA026-20170323190848')and trans_id = '21673148'
GO

------------------------------------------------------
UPDATE TOP (1) AUTHORIZATION_TRANSACTION 
SET state_id = 3
WHERE request_id = 'DHA-F-0048033-TPA026-20170323190848'
AND ID = '21673148'
AND state_id = 2 AND trans_src = (4)
GO 

