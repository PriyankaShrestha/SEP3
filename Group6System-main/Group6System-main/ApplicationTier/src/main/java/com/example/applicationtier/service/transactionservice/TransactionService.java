package com.example.applicationtier.service.transactionservice;

import com.example.applicationtier.models.Account;
import com.example.applicationtier.models.Transaction;

public interface TransactionService {
    String transferMoney(Transaction transaction) throws Exception;
    String payBill(Transaction transaction);
    Account getAccount(String username) throws Exception;
}
