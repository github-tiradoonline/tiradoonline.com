<!-- #include virtual="/includes/globals.inc" -->

<!-- #include virtual="/includes/open_connection.inc" -->
<!-- #include virtual="/includes/functions.inc" -->
<%
	ResumeFile = Trim(Request("ResumeFile"))
	SessionID = Session.SessionID
	IPAddress = Request.ServerVariables("REMOTE_ADDR")
	Browser = Request.ServerVariables("HTTP_USER_AGENT")
	Referer = Trim(Request("Referer"))
	If Referer = "" AND Request.ServerVariables("HTTP_REFERER") = "" Then Referer = "Outlook"
	
	sql = "sp_ResumeAnonymous_insert " & _
			"'" & SQLEncode(SessionID) & "', " & _
			"'" & SQLEncode(IPAddress) & "', " & _
			"'" & SQLEncode(Browser) & "', " & _
			"'" & SQLEncode(Referer) & "', " & _
			"'" & SQLEncode(ResumeFile) & "'"
	oConn.Execute sql
			
	v_ToEmail = Application("AdministratorEmail")
	v_FromEmail = Application("AdministratorEmail")
	v_CC = ""
	v_Subject = "Someone has downloaded your resume"
	v_BodyText = ""
	v_BodyText = v_BodyText & "Date/Time:<br>" & vbCrLF
	v_BodyText = v_BodyText & "----------------------------------------<br>" & vbCrLF
	v_BodyText = v_BodyText & Now & "<br><br>" & vbCrLF & vbCrLF

	v_BodyText = v_BodyText & "SessionID:<br>" & vbCrLF
	v_BodyText = v_BodyText & "----------------------------------------<br>" & vbCrLF
	v_BodyText = v_BodyText & SessionID & "<br><br>" & vbCrLF & vbCrLF

	v_BodyText = v_BodyText & "IP Address:<br>" & vbCrLF
	v_BodyText = v_BodyText & "----------------------------------------<br>" & vbCrLF
	v_BodyText = v_BodyText & IPAddress & "<br><br>" & vbCrLF & vbCrLF

	v_BodyText = v_BodyText & "Browser:<br>" & vbCrLF
	v_BodyText = v_BodyText & "----------------------------------------<br>" & vbCrLF
	v_BodyText = v_BodyText & Browser & "<br><br>" & vbCrLF & vbCrLF

	v_BodyText = v_BodyText & "Referer:<br>" & vbCrLF
	v_BodyText = v_BodyText & "----------------------------------------<br>" & vbCrLF
	v_BodyText = v_BodyText & Referer & "<br><br>" & vbCrLF & vbCrLF

	v_BodyText = v_BodyText & "Resume:<br>" & vbCrLF
	v_BodyText = v_BodyText & "----------------------------------------<br>" & vbCrLF
	v_BodyText = v_BodyText & ResumeFile & "<br><br>" & vbCrLF & vbCrLF
	
	v_isHTML = true
	v_attachment = ""
			
	SendEmail v_ToEmail, v_FromEmail, v_CC, v_Subject, v_BodyText, v_attachment, v_isHTML
	Response.Redirect "/resumes/" & ResumeFile
%>