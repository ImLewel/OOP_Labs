#include "framework.h"
#include "module2.rh"
#include <string> 

LPTSTR str;
LPTSTR buff;
static INT_PTR CALLBACK Work2Dlg(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    std::wstring groupStr;
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {

    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK) {
            int length = 20;
            buff = new TCHAR[20];
            GetDlgItemText(hDlg, IDC_EDIT1, buff, length);
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

LPCWSTR Func_MOD2(HWND hWnd, HINSTANCE hInst) {
    DialogBox(hInst, MAKEINTRESOURCE(IDD_DIALOG2), hWnd, Work2Dlg);
    return str;
}