

Process CMD;

/// <summary>
/// Lấy thông tin khởi tạo của cmd/powershell
/// </summary>
/// <returns></returns>
private processStartInfo GetStartInfo()
{
    ProcessStartInfo startInfo = new ProcessStartInfo();

    //startInfo.CreateNoWindow = chkbStyle.Checked; // nếu được check => không tạo cửa sổ
    startInfo.UseShellExecute = false;

    /*if (chkbAdmin.Checked)
        startInfo.Verb = "runas";*/

    startInfo.RedirectStandardInput = true; // hỗ trợ nhận lại dữ liệu đã nhập vào
    startInfo.RedirectStandardOutput = true; // hỗ trợ nhận kết quả

    startInfo.FileName = "powershell.exe";

    return startInfo;
}

/// <summary>
/// Thực thi lệnh và trả về kết quả
/// </summary>
/// <param name="msg"></param>
string excute(String msg)
{
    ProcessStartInfo startInfo = GetStartInfo();
    startInfo.Arguments = msg;

    Process CMD = new Process();
    CMD.StartInfo = startInfo;
    CMD.Start();

    CMD.WaitForExit();
    String result = CMD.StandardOutput.ReadToEnd();

    return result;
}
