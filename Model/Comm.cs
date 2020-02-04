
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Comm {

    /// <summary>
    /// @param DataSource
    /// </summary>
    public void Send(void DataSource);

    /// <summary>
    /// @param DataSource
    /// </summary>
    public void Receive(void DataSource);

}