#include "framework.h"
#include "module1.rh"
#include <string> 

LPCWSTR str;
static INT_PTR CALLBACK Work1Dlg(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    std::wstring groupStr;
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        for (int index = 1; index <= 3; index++) {
            groupStr = L"IM-1" + std::to_wstring(index);
            SendDlgItemMessage(hDlg, IDC_LIST1, LB_ADDSTRING, 0, (LPARAM)groupStr.c_str());
        }
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK) {
            int indx = SendDlgItemMessage(hDlg, IDC_LIST1, LB_GETCURSEL, 0, 0);
            int length = SendDlgItemMessage(hDlg, IDC_LIST1, LB_GETTEXTLEN, indx, 0);
            TCHAR* buff = new TCHAR[length++];
            SendDlgItemMessage(hDlg, IDC_LIST1, LB_GETTEXT, indx, (LPARAM)buff);
            str = buff;

            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;

        }
        else if (LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)FALSE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}

LPCWSTR Func_MOD1(HWND hWnd, HINSTANCE hInst) {
    DialogBox(hInst, MAKEINTRESOURCE(IDD_DIALOG1), hWnd, Work1Dlg);
    return str;
}