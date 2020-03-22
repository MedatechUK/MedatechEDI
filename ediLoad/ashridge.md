# Ashridge Integration

## Deserialisation

The web orders are deserialised from JSON using the [ashridge.Order object](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/ashridgeOrder.vb).

The deserialisation from the {file} specified occurs in the [Deserialise property](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Module1.vb#L53)

## Loading

Onced an [ashridge.Order](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/ashridgeOrder.vb) is deserialised, it is used to create two loadings.

### [customer record](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Module1.vb#L193) 

This creates a new transaction of type "CST" in the [ODAT_TRANS](https://github.com/MedatechUK/MedatechEDI/blob/master/PriorityForms/Schema/ODAT_TRANS.vb) definition.

Rows for this loading, including a RECORDTYPE, [are added](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Module1.vb#L206) to the sublevel [ODAT_LOAD](https://github.com/MedatechUK/MedatechEDI/blob/master/PriorityForms/Schema/ODAT_LOAD.vb) form.

Once all rows are posted [we set the upper level](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Module1.vb#L240) of [ODAT_TRANS](https://github.com/MedatechUK/MedatechEDI/blob/master/PriorityForms/Schema/ODAT_TRANS.vb) to complete, which triggers the loading interface specified in the ODATATYPE for the ODATATRANS.

### [order record](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Module1.vb#L262) 

This creates a new transaction of type "CST" in the [ODAT_TRANS](https://github.com/MedatechUK/MedatechEDI/blob/master/PriorityForms/Schema/ODAT_TRANS.vb) definition.

It works in the same way.