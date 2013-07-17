'Agent: Module to make sql queries to the dataset
'Date: 17th July 2013
'Author: Raghavi Sakpal

Module sqlQuery

    ' Function: To fill the data grid with Questions from Question_TBL
    Function fillQuestionDataGrid(ByVal patient_tableAdapter As Patient_TBIDataSet1TableAdapters.Question_TBLTableAdapter, ByVal patient_dataSet As Patient_TBIDataSet1)
        Return patient_tableAdapter.Fill(patient_dataSet.Question_TBL)
    End Function

    ' Function: To fill the data grid with Questions from FollowUp_TBL
    Function fillFollowUpDataFrid(ByVal patient_tableAdapter As Patient_TBIDataSet1TableAdapters.FollowUp_TBLTableAdapter, ByVal patient_dataSet As Patient_TBIDataSet1)
        Return patient_tableAdapter.Fill(patient_dataSet.FollowUp_TBL)
    End Function

End Module
