package com.example.applicationtier.DAO.admin;

import com.example.applicationtier.DAO.Handler;
import com.example.applicationtier.models.Account;
import com.example.applicationtier.models.Customer;
import com.example.applicationtier.models.Request;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class AdminDAOImpl implements AdminDAO {
    @Autowired
    private Handler handler;
    private final ObjectMapper mapper = new ObjectMapper();

    @Override
    public boolean validateCustomer(Customer customer) {
        Request obj = new Request("IsValid", customer);
        handler.setObj(obj);

        Request response = handler.messageExchange(obj);
        Customer customer1 = mapper.convertValue(response.getObj(), Customer.class);
        return customer1.isValid();
    }

    @Override
    public List<Customer> getAllCustomers() {
        Request obj = new Request("GetAllCustomers");
        handler.setObj(obj);

        Request response = handler.messageExchange(obj);
        return mapper.convertValue(response.getObj(),
                new TypeReference<>() {
                });
    }

    @Override
    public String removeCustomer(int cprNumber){
        Request obj = new Request("RemoveCustomerByCprNumber", cprNumber);
        handler.setObj(obj);
        System.out.println("Inside dao send request -->  " + obj);

        Request response = handler.messageExchange(obj);
       if(response.getHeader().equals("RemoveCustomerByCprNumber")){
           System.out.println("Inside dao response " + response.getObj());
           return (String) response.getObj();
       }
       else return "Customer not found!";
    }

    @Override
    public Account CreateAccount(Account account) throws Exception {

        Request account1 = new Request("CreateAccount", account);
        handler.setObj(account1);

        Request response = handler.messageExchange(account1);

        if(response.getHeader().equals("AccountCreate")) {
            Account acc = mapper.convertValue(response.getObj(), Account.class);
            return acc;
        }
        else throw new Exception((String) response.getObj());
    }

    @Override
    public long getLastAccountNumber() {
        Request lastUsedAccountNumber = new Request("GetLastUsedAccountNumber", null);
        handler.setObj(lastUsedAccountNumber);

        Request response = handler.messageExchange(lastUsedAccountNumber);

        if(response.getHeader().equals("LastUsedAccountNumber")) {
            System.out.println(response.getObj());
            long lastNumber = mapper.convertValue(response.getObj(), long.class);
            return lastNumber;
        }
        else return 0;
    }

}
